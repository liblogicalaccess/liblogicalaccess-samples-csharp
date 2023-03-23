using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Reader;
using System;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public class CardServiceTask
    {
        ReaderConfiguration readerConfig;

        public CardServiceTask(ReaderConfiguration readerConfig)
        {
            this.readerConfig = readerConfig;
        }

        public T Run<T>(Func<T, IChip, Location, AccessInfo, AccessInfo, T> action, T parameter = default)
        {
            T ret = default;
            try
            {
                var readerUnit = readerConfig.getReaderUnit();
                if (readerUnit.connectToReader())
                {
                    if (readerUnit.waitInsertion(5000))
                    {
                        if (readerUnit.connect())
                        {
                            var chip = readerUnit.getSingleChip();
                            if (chip != null)
                            {
                                Location location = null;
                                AccessInfo aiToUse = null;
                                AccessInfo aiToWrite = null;

                                if (chip.getGenericCardType() == "DESFire")
                                {
                                    location = new DESFireLocation();
                                    aiToUse = new DESFireAccessInfo();
                                    aiToWrite = new DESFireAccessInfo();

                                    var dlocation = (location as DESFireLocation);
                                    dlocation.aid = 0x000555;
                                    dlocation.file = 0;

                                    var daiToWrite = (aiToWrite as DESFireAccessInfo);
                                    var desfireKey2 = new DESFireKey();
                                    desfireKey2.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 aa");
                                    var desfireKey1 = new DESFireKey();
                                    desfireKey1.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 bb");
                                    var masterKey = new DESFireKey();
                                    masterKey.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 cc");

                                    daiToWrite.readKey = desfireKey2;
                                    daiToWrite.readKeyno = 2;

                                    daiToWrite.writeKey = desfireKey1;
                                    daiToWrite.writeKeyno = 1;
                                    daiToWrite.masterApplicationKey = masterKey;
                                }

                                ret = action(parameter, chip, location, aiToUse, aiToWrite);
                            }
                            readerUnit.disconnect();
                        }
                        readerUnit.waitRemoval(2000);
                    }
                    else
                        MessageBox.Show("No card detected !", "Error:", MessageBoxButtons.OK);
                    readerUnit.disconnectFromReader();
                }
                else
                    throw new Exception("Cannot   connect to the PCSC reader.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK);
            }
            return ret;
        }
    }
}

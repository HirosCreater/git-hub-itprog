using MuseumObserverLogic.Entity;

namespace MuseumObserverLogic
{
    class Logic
    {
        public interface ILogic
        {
            DataSetMuseum getShowroom();
            bool setShowroom(DataSetMuseum dataSet);

            DataSetMuseum getRestorer();
            bool setRestorer(DataSetMuseum dataSet);

            DataSetMuseum getRestoration();
            bool setRestoration(DataSetMuseum dataSet);

            DataSetMuseum getRent();
            bool setRent(DataSetMuseum dataSet);

            DataSetMuseum getMuseum();
            bool setMuseum(DataSetMuseum dataSet);

            DataSetMuseum getMaecenas();
            bool setMaecenas(DataSetMuseum dataSet);

            DataSetMuseum getExhibition();
            bool setExhibition(DataSetMuseum dataSet);

            DataSetMuseum getExhibit_Exhibition();
            bool setExhibit_Exhibition(DataSetMuseum dataSet);

            DataSetMuseum getExhibit();
            bool setExhibit(DataSetMuseum dataSet);

            DataSetMuseum getCrutch();
            bool setCrutch(DataSetMuseum dataSet);

            DataSetMuseum getCategory();
            bool setCategory(DataSetMuseum dataSet);
        }

        public class Logic : ILogic
        {
            private Showroom showroom;
            private Restorer restorer;
            private Restoration restoration;
            private Rent rent;
            private Museum museum;
            private Maecenas maecenas;
            private Exhibition exhibition;
            private Exhibit_Exhibition exhibit_Exhibition;
            private Exhibit exhibit;
            private Crutch crutch;
            private Category category;

            public DataSetMuseum getShowroom()
            {
                DataSetMuseum result = new DataSetMuseum();
                Connection connection = new Connection();
                connection.Open();
                try
                {
                    Transaction transaction = connection.BeginTransaction();
                    try
                    {
                        showroom = new Showroom();
                        showroom.Read(result, connection, transaction);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        result = null;
                    }
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
            public bool setCharacteristics(DataSetMuseum dataSet)
            {
                bool result = false;
                Connection connection = new Connection();
                connection.Open();
                try
                {
                    Transaction transaction = connection.BeginTransaction();
                    try
                    {
                        showroom = new Showroom();
                        showroom.Save(dataSet, connection, transaction);
                        transaction.Commit();
                        result = true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        result = false;
                    }
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }
    }
}

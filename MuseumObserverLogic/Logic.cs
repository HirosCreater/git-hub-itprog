using MuseumObserverLogic.Entity;
using System;
using System.Windows.Forms;

namespace MuseumObserverLogic
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
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setShowroom(DataSetMuseum dataSet)
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
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getRestorer()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    restorer = new Restorer();
                    restorer.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setRestorer(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    restorer = new Restorer();
                    restorer.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getRestoration()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    restoration = new Restoration();
                    restoration.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setRestoration(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    restoration = new Restoration();
                    restoration.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getRent()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    rent = new Rent();
                    rent.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setRent(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
               try
               {
                    rent = new Rent();
                    rent.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getMuseum()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    museum = new Museum();
                    museum.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setMuseum(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    museum = new Museum();
                    museum.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getMaecenas()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    maecenas = new Maecenas();
                    maecenas.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setMaecenas(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    maecenas = new Maecenas();
                    maecenas.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getExhibition()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibition = new Exhibition();
                    exhibition.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setExhibition(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibition = new Exhibition();
                    exhibition.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getExhibit_Exhibition()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibit_Exhibition = new Exhibit_Exhibition();
                    exhibit_Exhibition.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setExhibit_Exhibition(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibit_Exhibition = new Exhibit_Exhibition();
                    exhibit_Exhibition.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public DataSetMuseum getExhibit()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibit = new Exhibit();
                    exhibit.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setExhibit(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    exhibit = new Exhibit();
                    exhibit.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString()); 
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

        public DataSetMuseum getCrutch()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    crutch = new Crutch();
                    crutch.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setCrutch(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    crutch = new Crutch();
                    crutch.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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

        public DataSetMuseum getCategory()
        {
            DataSetMuseum result = new DataSetMuseum();
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    category = new Category();
                    category.Read(result, connection, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public bool setCategory(DataSetMuseum dataSet)
        {
            bool result = false;
            Connection connection = new Connection();
            connection.Open();
            try
            {
                Transaction transaction = connection.BeginTransaction();
                try
                {
                    category = new Category();
                    category.Save(dataSet, connection, transaction);
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    ShowError(ex.ToString());
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
        public void ShowError(string showSTR)
        {
            MessageBox.Show(
                showSTR,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}

using CassetteRentals.Models;
using System.ComponentModel;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace CassetteRentals
{
    public partial class MainForm : Form
    {
        private string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cassette_rentals.db");

        private List<Client> clients = new List<Client>();
        private List<Movie> movies = new List<Movie>();
        //private int nextClientId = 1; // For generating unique IDs
        private int? selectedClientId = null;
        private int? selectedMovieId = null;


        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Display { get; set; }

            public override string ToString() => Display;
        }
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            textBoxEmail.Validating += TextBoxEmail_Validating;
            textBoxPhone.Validating += TextBoxPhone_Validating;
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                errorProvider.SetError(textBoxEmail, "Invalid email format.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxEmail, string.Empty);
            }
        }

        private void TextBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^0[0-9]{9}$";
            if (!Regex.IsMatch(textBoxPhone.Text, pattern))
            {
                errorProvider.SetError(textBoxPhone, "Phone must be exactly 10 digits.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxPhone, string.Empty);
            }
        }
        private void LoadClientsFromDatabase()
        {
            clients.Clear();
            listViewClients.Items.Clear();

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // Always enable foreign keys in SQLite
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string query = "SELECT * FROM Clients";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var client = new Client
                        {
                            ClientId = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Phone = reader.GetString(reader.GetOrdinal("Phone"))
                        };

                        clients.Add(client);

                        var item = new ListViewItem(client.ClientId.ToString());
                        item.SubItems.Add(client.FirstName);
                        item.SubItems.Add(client.LastName);
                        item.SubItems.Add(client.Email);
                        item.SubItems.Add(client.Phone);
                        listViewClients.Items.Add(item);
                    }
                }
            }

            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadMoviesFromDatabase()
        {
            movies.Clear();
            listViewMovies.Items.Clear();

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                    pragmaCmd.ExecuteNonQuery();

                string query = "SELECT * FROM Movies";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movie = new Movie
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Genre = reader.GetString(reader.GetOrdinal("Genre")),
                            Year = reader.GetInt32(reader.GetOrdinal("Year")),
                            IsAvailable = reader.GetInt32(reader.GetOrdinal("IsAvailable")) == 1
                        };

                        movies.Add(movie);

                        var item = new ListViewItem(movie.Id.ToString());
                        item.SubItems.Add(movie.Title);
                        item.SubItems.Add(movie.Genre);
                        item.SubItems.Add(movie.Year.ToString());
                        item.SubItems.Add(movie.IsAvailable ? "Yes" : "No");
                        listViewMovies.Items.Add(item);
                    }
                }
            }

            listViewMovies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewMovies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count == 0)
            {
                selectedMovieId = null;
                return;
            }

            var selectedItem = listViewMovies.SelectedItems[0];
            selectedMovieId = int.Parse(selectedItem.SubItems[0].Text);

            var movie = movies.FirstOrDefault(m => m.Id == selectedMovieId);
            if (movie != null)
            {
                textBoxTitle.Text = movie.Title;
                textBoxGenre.Text = movie.Genre;
                textBoxYear.Text = movie.Year.ToString();
                chkBoxAvailable.Checked = movie.IsAvailable;
            }
        }

        private void LoadClientComboBox()
        {
            comboBoxClients.Items.Clear();
            foreach (var client in clients)
            {
                comboBoxClients.Items.Add(new ComboBoxItem
                {
                    Id = client.ClientId,
                    Display = $"{client.FirstName} {client.LastName}"
                });
            }
        }

        private void LoadMovieComboBox()
        {
            comboBoxMovies.Items.Clear();
            foreach (var movie in movies.Where(m => m.IsAvailable))
            {
                comboBoxMovies.Items.Add(new ComboBoxItem
                {
                    Id = movie.Id,
                    Display = $"{movie.Title} ({movie.Year})"
                });
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientsTab_Click(object sender, EventArgs e)
        {

        }

        private void labelLn_Click(object sender, EventArgs e)
        {

        }

        private void listViewRentals_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listViewRentals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCbMovie_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            LoadClientsFromDatabase();
            LoadMoviesFromDatabase();
            LoadClientComboBox();
            LoadMovieComboBox();
            LoadRentalsFromDatabase();
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                selectedClientId = null;
                return;
            }

            var selectedItem = listViewClients.SelectedItems[0];
            selectedClientId = int.Parse(selectedItem.SubItems[0].Text);

            var client = clients.FirstOrDefault(c => c.ClientId == selectedClientId);
            if (client != null)
            {
                textBoxFn.Text = client.FirstName;
                textBoxLn.Text = client.LastName;
                textBoxEmail.Text = client.Email;
                textBoxPhone.Text = client.Phone;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxFn.Text) ||
                string.IsNullOrWhiteSpace(textBoxLn.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Please fill in all client fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO Clients (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFn.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", textBoxLn.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
            }

            // Clear input fields
            textBoxFn.Clear();
            textBoxLn.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();

            // Reload clients from DB
            LoadClientsFromDatabase();
            LoadClientComboBox();
        }
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            if (selectedClientId == null)
            {
                MessageBox.Show("Please select a client to edit.");
                return;
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string updateQuery = @"
            UPDATE Clients 
            SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone 
            WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFn.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", textBoxLn.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", selectedClientId.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reset selection and fields
            selectedClientId = null;
            textBoxFn.Clear();
            textBoxLn.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();

            LoadClientsFromDatabase();
            LoadClientComboBox();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (selectedClientId == null)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this client?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string deleteQuery = "DELETE FROM Clients WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedClientId.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reset UI
            selectedClientId = null;
            textBoxFn.Clear();
            textBoxLn.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();

            // Refresh list
            LoadClientsFromDatabase();
            LoadClientComboBox();
        }

        private void brnAddMve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
        string.IsNullOrWhiteSpace(textBoxGenre.Text) ||
        string.IsNullOrWhiteSpace(textBoxYear.Text))
            {
                MessageBox.Show("Please fill in all movie fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxYear.Text.Trim(), out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO Movies (Title, Genre, Year, IsAvailable) VALUES (@Title, @Genre, @Year, @IsAvailable)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Genre", textBoxGenre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@IsAvailable", chkBoxAvailable.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }

            // Clear fields
            textBoxTitle.Clear();
            textBoxGenre.Clear();
            textBoxYear.Clear();
            chkBoxAvailable.Checked = false;

            // Reload
            LoadMoviesFromDatabase();
            LoadMovieComboBox();
        }

        private void btnEditMve_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == null)
            {
                MessageBox.Show("Please select a movie to edit.");
                return;
            }

            if (!int.TryParse(textBoxYear.Text.Trim(), out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string query = @"UPDATE Movies 
                         SET Title = @Title, Genre = @Genre, Year = @Year, IsAvailable = @IsAvailable 
                         WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Genre", textBoxGenre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@IsAvailable", chkBoxAvailable.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Id", selectedMovieId.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            selectedMovieId = null;
            textBoxTitle.Clear();
            textBoxGenre.Clear();
            textBoxYear.Clear();
            chkBoxAvailable.Checked = false;

            LoadMoviesFromDatabase();
            LoadMovieComboBox();
        }

        private void btnDeleteMve_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == null)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this movie?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string deleteQuery = "DELETE FROM Movies WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedMovieId.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            selectedMovieId = null;
            textBoxTitle.Clear();
            textBoxGenre.Clear();
            textBoxYear.Clear();
            chkBoxAvailable.Checked = false;

            LoadMoviesFromDatabase();
            LoadMovieComboBox();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem == null || comboBoxMovies.SelectedItem == null)
            {
                MessageBox.Show("Please select a client and a movie.");
                return;
            }

            var clientItem = (ComboBoxItem)comboBoxClients.SelectedItem;
            var movieItem = (ComboBoxItem)comboBoxMovies.SelectedItem;
            var rentalDate = dateTimeRental.Value;

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // Enforce foreign key constraints
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                // Insert rental with NULL ReturnDate
                string insertRental = @"INSERT INTO Rentals (ClientId, MovieId, RentalDate, ReturnDate)
                                VALUES (@ClientId, @MovieId, @RentalDate, NULL)";
                using (var cmd = new SQLiteCommand(insertRental, conn))
                {
                    cmd.Parameters.AddWithValue("@ClientId", clientItem.Id);
                    cmd.Parameters.AddWithValue("@MovieId", movieItem.Id);
                    cmd.Parameters.AddWithValue("@RentalDate", rentalDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }

                // Mark movie as unavailable
                string updateMovie = "UPDATE Movies SET IsAvailable = 0 WHERE Id = @MovieId";
                using (var cmd = new SQLiteCommand(updateMovie, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movieItem.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rental added successfully!");

            // Refresh UI
            LoadMoviesFromDatabase();
            LoadMovieComboBox();
            LoadRentalsFromDatabase();

            comboBoxClients.SelectedItem = null;
            comboBoxMovies.SelectedItem = null;
            comboBoxMovies.Text = "";
        }

        private void LoadRentalsFromDatabase()
        {
            listViewRentals.Items.Clear();

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string query = @"
            SELECT r.Id, 
                   c.FirstName || ' ' || c.LastName AS ClientName,
                   m.Title AS MovieTitle,
                   r.RentalDate,
                   r.ReturnDate
            FROM Rentals r
            JOIN Clients c ON r.ClientId = c.Id
            JOIN Movies m ON r.MovieId = m.Id";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["ClientName"].ToString());
                        item.SubItems.Add(reader["MovieTitle"].ToString());
                        item.SubItems.Add(reader["RentalDate"].ToString());
                        item.SubItems.Add(reader["ReturnDate"].ToString());
                        listViewRentals.Items.Add(item);
                    }
                }
            }

            listViewRentals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRentals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnReturnRental_Click(object sender, EventArgs e)
        {
            if (listViewRentals.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a rental to return.");
                return;
            }

            int rentalId = int.Parse(listViewRentals.SelectedItems[0].SubItems[0].Text);
            DateTime returnDate = DateTime.Today;

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // 1. Update ReturnDate for the rental
                string updateRental = @"UPDATE Rentals SET ReturnDate = @ReturnDate WHERE Id = @RentalId";
                using (var cmd = new SQLiteCommand(updateRental, conn))
                {
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@RentalId", rentalId);
                    cmd.ExecuteNonQuery();
                }

                // 2. Get MovieId for this rental
                int movieId = -1;
                string getMovieId = "SELECT MovieId FROM Rentals WHERE Id = @RentalId";
                using (var cmd = new SQLiteCommand(getMovieId, conn))
                {
                    cmd.Parameters.AddWithValue("@RentalId", rentalId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            movieId = Convert.ToInt32(reader["MovieId"]);
                        }
                    }
                }

                // 3. Mark the movie as available again
                if (movieId != -1)
                {
                    string updateMovie = "UPDATE Movies SET IsAvailable = 1 WHERE Id = @MovieId";
                    using (var cmd = new SQLiteCommand(updateMovie, conn))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Rental marked as returned.");

            LoadRentalsFromDatabase();
            LoadMoviesFromDatabase();
            LoadMovieComboBox();
        }


    }
}

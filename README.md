# Currency-Apps
Aplikasi inia dalah aplkiasi yang bisa mengconversi mata uang Rupiah(indonesia) ke mata uang USD(Amerika)
## Scope and Funcionalities
* User dapat mengkonversi nilai mata uang rupiah ke mata uang Dollar
* User dapat mengklik tomol hitung untuk memulai mengkonversi
* User akan melihat tulisan invalid ketika user salah memasukan nilai atau huruf yang ingin di konversi
## How Does It Works
         var nominalString = InputTextBox.Text;
         resultLabel.Content = nominalString;
Kode diatas adalah kode untuk mengkonversi nilai menjadi angka.
Selanjutanya pembahasan kode Button_ Hitung_Click

#
...
 var nominalString = InputTextBox.Text;
            Regex regex = new Regex("[^0-9.-]+");
            if (!regex.IsMatch(nominalString))
            {
                var nominalDouble = Convert.ToDouble(nominalString);
                resultLabel.Content = Convert.ToString(nominalDouble * 4);
            }
            Else             {
                resultLabel.Content = "Invalid";
            }
##...

Bisa dilihat di ataas adalah kode untuk menkonversi hasil nilai yang ingin kita input
misalkan kita memasukan angka 3 USD, maka otomatis nilai hassilnya dalah 15000, karna kita telah
menginput nilai 1 USD adalah = Rp15000.
Dan juga akan muncul kata "Invalid" pada keterangan jika user salah mengetikan angka atau huruf.

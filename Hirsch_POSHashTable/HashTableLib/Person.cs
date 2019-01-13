using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace HashTableLib
{
    public class Person
    {
        public string klasse { get; set; }
        public string name { get; set; }
        public string vorname { get; set; }

        public string RecordID { get; set; }
        public BigInteger hashBigInt { get; set; }

        public bool isInserted { get; set; }

        public Person(string klasse, string name, string vorname)
        {
            this.klasse = klasse;
            this.name = name;
            this.vorname = vorname;
            this.isInserted = false;

            this.RecordID = GenerateHash(klasse+name+vorname);
        }

        private string GenerateHash(string val)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(val);

            byte[] hash = md5.ComputeHash(inputBytes);

            hashBigInt = new BigInteger(hash);
            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return "Klasse: " + klasse + "\tName: " + name + "\t\tVorname: " + vorname + "\t\tHash: " + RecordID;
        }
    }
}

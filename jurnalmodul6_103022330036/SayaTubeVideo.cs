using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul6_103022330036
{
    public class SayaTubeVideo
    {
        private int id;
        private string judulVideo;
        private int playCount;

        public SayaTubeVideo(string judulVideo)
        {
            if (judulVideo == null)
            {
                throw new ArgumentNullException("judulVideo", "Judul video tidak boleh kosong");
            }
            if(judulVideo.Length > 200)
            {
                throw new ArgumentException("Judul video harus lebih dari 200 kata");
            }
            Random rnd = new Random();
            this.id = rnd.Next(1000, 99999);
            this.judulVideo = judulVideo;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            Debug.Assert(count < 100000, "Jumlah views harus lebih dari 0 tetapi tidak lebih dari 100000");
                try
            {
                checked
                {
                    if(this.playCount + count > 100000)
                    {
                        throw new OverflowException("Jumlah views tidak boleh lebih dari 100000");
                    }   
                    this.playCount += count;    
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Terjadi error! lebih dari maksimum karakter" + e.Message);
                this.playCount = 100000;
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.judulVideo);
            Console.WriteLine("Play Count: " + this.playCount); 
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}

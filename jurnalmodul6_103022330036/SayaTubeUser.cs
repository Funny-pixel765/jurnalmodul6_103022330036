using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul6_103022330036
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public void getTotalVideoPlayCount()
        {
            int count = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                count += uploadedVideos[i]. getPlayCount();
            }
            
        }

        public void addVideo(SayaTubeVideo video)
        {
            Contract.Requires(video.getPlayCount() > 250000 && video != null);
            Debug.Assert(video.getPlayCount() < 250000 && video != null, "Jumlah views harus lebih dari 250000");
            uploadedVideos.Add(video);
        }
    }
}

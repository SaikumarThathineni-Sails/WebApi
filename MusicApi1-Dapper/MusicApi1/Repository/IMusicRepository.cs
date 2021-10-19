using MusicApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi1.Repository
{
    public interface IMusicRepository
    {
        List<Song> Get();
        Song Find(int id);
    }
}

using System;

namespace Fauna
{
    public interface ITame
    {      
        public string Name { get; set; }

       string ComeHere();
       void TalkToOwner();
    }
}
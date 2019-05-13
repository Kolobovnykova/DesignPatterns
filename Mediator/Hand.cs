using System;

namespace Mediator
{
    public class Hand : BodyPart
    {
        public Hand(Brain brain) : base(brain)
        {
        }

        public void HitPersonNearYou()
        {
        }

        public void Embrace()
        {
        }

        public bool IsItNice()
        {
            return DateTimeOffset.Now.Ticks % 2 == 1;
        }

        public bool DoesItHurt()
        {
            return DateTimeOffset.Now.Ticks % 2 == 1;
        }
    }
}

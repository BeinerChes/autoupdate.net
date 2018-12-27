﻿namespace AutoUpdate.Core.Model.Server
{
    public class EmptyVersionDownloadSource : VersionDownloadSource
    {
        public override void Accept(IVersionDownloadSourceVisitor visitor)
            => visitor.Handle(this);

        public override TReturn Accept<TReturn>(IVersionDownloadSourceVisitor<TReturn> visitor)
            => visitor.Handle(this);
    }
}

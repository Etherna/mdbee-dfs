﻿//   Copyright 2021 Etherna Sagl
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using MongoDB.Bson;

namespace Etherna.MongoDBSyncer.EventArgs
{
    public class OnDocumentRemovedEventArgs
    {
        public OnDocumentRemovedEventArgs(
            string dbName,
            BsonElement docId,
            BsonTimestamp oplogTimestamp)
        {
            DbName = dbName;
            DocId = docId;
            OplogTimestamp = oplogTimestamp;
        }

        public string DbName { get; }
        public BsonElement DocId { get; }
        public BsonTimestamp OplogTimestamp { get; }
    }
}

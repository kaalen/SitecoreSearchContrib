namespace scSearchContrib.Crawler
{
    public class SearchField
    {
        public SearchField()
        {
        }

        public SearchField(string storageType, string indexType, string vectorType, string boost, string exclude)
        {
            SetStorageType(storageType);
            SetIndexType(indexType);
            SetVectorType(vectorType);
            Exclude = Sitecore.MainUtil.StringToBool(exclude, false);
        }

        #region Public Properties

        public Lucene.Net.Documents.Field.Store StorageType { get; set; }

        public Lucene.Net.Documents.Field.Index IndexType { get; set; }

        public Lucene.Net.Documents.Field.TermVector VectorType { get; set; }

        public float Boost { get; set; }

        public bool Exclude { get; set; }

        #endregion

        #region Setters

        public void SetStorageType(string storageType)
        {
            switch (storageType)
            {
                case "YES":
                    {
                        StorageType = Lucene.Net.Documents.Field.Store.YES;
                        break;
                    }
                case "NO":
                    {
                        StorageType = Lucene.Net.Documents.Field.Store.NO;
                        break;
                    }
                default:
                    break;
            }
        }

        public void SetIndexType(string indexType)
        {
            switch (indexType)
            {
				case "NO":
					{
						IndexType = Lucene.Net.Documents.Field.Index.NO;
						break;
					}
				case "NO_NORMS":
					{
						IndexType = Lucene.Net.Documents.Field.Index.NOT_ANALYZED_NO_NORMS;
						break;
					}
				case "TOKENIZED":
					{
						IndexType = Lucene.Net.Documents.Field.Index.ANALYZED;
						break;
					}
				case "UN_TOKENIZED":
					{
						IndexType = Lucene.Net.Documents.Field.Index.NOT_ANALYZED;
						break;
					}
				default:
					break;
			}
        }

        public void SetVectorType(string vectorType)
        {
            switch (vectorType)
            {
                case "NO":
                    {
                        VectorType = Lucene.Net.Documents.Field.TermVector.NO;
                        break;
                    }
                case "WITH_OFFSETS":
                    {
                        VectorType = Lucene.Net.Documents.Field.TermVector.WITH_OFFSETS;
                        break;
                    }
                case "WITH_POSITIONS":
                    {
                        VectorType = Lucene.Net.Documents.Field.TermVector.WITH_POSITIONS;
                        break;
                    }
                case "WITH_POSITIONS_OFFSETS":
                    {
                        VectorType = Lucene.Net.Documents.Field.TermVector.WITH_POSITIONS_OFFSETS;
                        break;
                    }
                case "YES":
                    {
                        VectorType = Lucene.Net.Documents.Field.TermVector.YES;
                        break;
                    }
                default:
                    break;
            }
        }

        #endregion
    }
}

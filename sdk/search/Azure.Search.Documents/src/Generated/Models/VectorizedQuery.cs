// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> The query parameters to use for vector search when a raw vector value is provided. </summary>
    public partial class VectorizedQuery : VectorQuery
    {
        /// <summary> Initializes a new instance of <see cref="VectorizedQuery"/>. </summary>
        /// <param name="vector"> The vector representation of a search query. </param>
        public VectorizedQuery(ReadOnlyMemory<float> vector)
        {
            Vector = vector;
            Kind = VectorQueryKind.Vector;
        }

        /// <summary> Initializes a new instance of <see cref="VectorizedQuery"/>. </summary>
        /// <param name="kind"> The kind of vector query being performed. </param>
        /// <param name="kNearestNeighborsCount"> Number of nearest neighbors to return as top hits. </param>
        /// <param name="fieldsRaw"> Vector Fields of type Collection(Edm.Single) to be included in the vector searched. </param>
        /// <param name="exhaustive"> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </param>
        /// <param name="oversampling"> Oversampling factor. Minimum value is 1. It overrides the 'defaultOversampling' parameter configured in the index definition. It can be set only when 'rerankWithOriginalVectors' is true. This parameter is only permitted when a compression method is used on the underlying vector field. </param>
        /// <param name="weight"> Relative weight of the vector query when compared to other vector query and/or the text query within the same search request. This value is used when combining the results of multiple ranking lists produced by the different vector queries and/or the results retrieved through the text query. The higher the weight, the higher the documents that matched that query will be in the final ranking. Default is 1.0 and the value needs to be a positive number larger than zero. </param>
        /// <param name="vector"> The vector representation of a search query. </param>
        internal VectorizedQuery(VectorQueryKind kind, int? kNearestNeighborsCount, string fieldsRaw, bool? exhaustive, double? oversampling, float? weight, ReadOnlyMemory<float> vector) : base(kind, kNearestNeighborsCount, fieldsRaw, exhaustive, oversampling, weight)
        {
            Vector = vector;
            Kind = kind;
        }
    }
}

﻿using Loader.OTB.Enums;
using Loader.OTB.Parsers;
using Xunit;

namespace Loader.Tests.OTB.Parsers;

public class OTBBinaryTreeBuilderTest
{
    [Fact]
    public void Deserialize_ReturnsOTBNodeInstance()
    {
        var data = new byte[]
        {
            0, 0, 0, 0,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.MapData,
            3,
            (byte)OtbMarkupByte.Escape,
            (byte)OtbMarkupByte.Escape,
            4,
            6,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.TileArea,
            3,
            4,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.NormalTile,
            2,

            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.NormalTile,
            7,

            (byte)OtbMarkupByte.Start,
            (byte)NodeType.Item,
            6,
            (byte)OtbMarkupByte.End,

            (byte)OtbMarkupByte.Start,
            (byte)NodeType.Item,
            9,
            5,

            (byte)OtbMarkupByte.Start,
            (byte)NodeType.Item,
            3,
            (byte)OtbMarkupByte.End,

            (byte)OtbMarkupByte.End,

            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.TileArea,
            3,
            4,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.NormalTile,
            2,

            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.Start,
            (byte)NodeType.NormalTile,
            7,

            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.End,
            (byte)OtbMarkupByte.End
        };

        var node = OtbBinaryTreeBuilder.Deserialize(data);

        Assert.NotNull(node); //todo
    }
}
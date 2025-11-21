// Licensed under the MIT License.

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for Terraform built-in functions in the Tf.Functions class.
/// </summary>
public class TfFunctionsTests
{
    [Fact]
    public Task CidrSubnet_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var prefix = "10.0.0.0/16";
        var newbits = 8;
        var netnum = 1;

        var output = new TerraformOutput("subnet")
        {
            Value = Tf.Functions.CidrSubnet(prefix, newbits, netnum)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Length_WithList_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var list = new TerraformList<string> { "a", "b", "c" };

        var output = new TerraformOutput("list_length")
        {
            Value = Tf.Functions.Length(list)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Length_WithMap_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var map = new TerraformMap<string>
        {
            ["key1"] = "value1",
            ["key2"] = "value2"
        };

        var output = new TerraformOutput("map_length")
        {
            Value = Tf.Functions.Length(map)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Length_WithSet_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var set = new TerraformSet<string> { "a", "b", "c" };

        var output = new TerraformOutput("set_length")
        {
            Value = Tf.Functions.Length(set)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Length_WithString_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var str = "hello";

        var output = new TerraformOutput("string_length")
        {
            Value = Tf.Functions.Length(str)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Element_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var list = new TerraformList<string> { "first", "second", "third" };
        var index = 1;

        var output = new TerraformOutput("element")
        {
            Value = Tf.Functions.Element(list, index)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Join_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var separator = ", ";
        var list = new TerraformList<string> { "a", "b", "c" };

        var output = new TerraformOutput("joined")
        {
            Value = Tf.Functions.Join(separator, list)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Format_WithSingleArgument_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var formatString = "Hello, %s!";
        var arg = "World";

        var output = new TerraformOutput("formatted")
        {
            Value = Tf.Functions.Format<string>(formatString, arg)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Format_WithMultipleArguments_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var formatString = "%s-%s";
        var arg1 = "prefix";
        var arg2 = "suffix";

        var output = new TerraformOutput("formatted")
        {
            Value = Tf.Functions.Format<string>(formatString, arg1, arg2)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Lookup_WithoutDefault_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var map = new TerraformMap<string>
        {
            ["key1"] = "value1",
            ["key2"] = "value2"
        };
        TerraformValue<string> key = "key1";

        var output = new TerraformOutput("looked_up")
        {
            Value = Tf.Functions.Lookup(map, key)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Lookup_WithDefault_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var map = new TerraformMap<string>
        {
            ["key1"] = "value1"
        };
        TerraformValue<string> key = "key2";
        TerraformValue<string> defaultValue = "default";

        var output = new TerraformOutput("looked_up")
        {
            Value = Tf.Functions.Lookup(map, key, defaultValue)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Concat_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var list1 = new TerraformList<string> { "a", "b" };
        var list2 = new TerraformList<string> { "c", "d" };

        var output = new TerraformOutput("concatenated")
        {
            Value = Tf.Functions.Concat(list1, list2)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task File_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<string> path = "config.json";

        var output = new TerraformOutput("file_contents")
        {
            Value = Tf.Functions.File(path)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Range_WithMax_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<int> max = 5;

        var output = new TerraformOutput("range")
        {
            Value = Tf.Functions.Range(max)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Range_WithStartAndLimit_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<int> start = 1;
        TerraformValue<int> limit = 10;

        var output = new TerraformOutput("range")
        {
            Value = Tf.Functions.Range(start, limit)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Range_WithStartLimitAndStep_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<int> start = 0;
        TerraformValue<int> limit = 10;
        TerraformValue<int> step = 2;

        var output = new TerraformOutput("range")
        {
            Value = Tf.Functions.Range(start, limit, step)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToString_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<int> value = 42;

        var output = new TerraformOutput("string_value")
        {
            Value = Tf.Functions.ToString(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToNumber_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<string> value = "123";

        var output = new TerraformOutput("number_value")
        {
            Value = Tf.Functions.ToNumber(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToBool_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<string> value = "true";

        var output = new TerraformOutput("bool_value")
        {
            Value = Tf.Functions.ToBool(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToList_FromValue_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        TerraformValue<string> value = "item";

        var output = new TerraformOutput("list_value")
        {
            Value = Tf.Functions.ToList(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToList_FromSet_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var set = new TerraformSet<string> { "a", "b", "c" };

        var output = new TerraformOutput("list_value")
        {
            Value = Tf.Functions.ToList(set)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToMap_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var value = "value";

        var output = new TerraformOutput("map_value")
        {
            Value = Tf.Functions.ToMap<string>(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToSet_FromValue_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var value = "item";

        var output = new TerraformOutput("set_value")
        {
            Value = Tf.Functions.ToSet<string>(value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ToSet_FromList_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var list = new TerraformList<string> { "a", "b", "c" };

        var output = new TerraformOutput("set_value")
        {
            Value = Tf.Functions.ToSet(list)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Merge_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var map1 = new TerraformMap<string>
        {
            ["key1"] = "value1"
        };
        var map2 = new TerraformMap<string>
        {
            ["key2"] = "value2"
        };

        var output = new TerraformOutput("merged")
        {
            Value = Tf.Functions.Merge(map1, map2)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Index_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var list = new TerraformList<string> { "a", "b", "c" };
        var value = "b";

        var output = new TerraformOutput("index")
        {
            Value = Tf.Functions.Index(list, value)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task Function_WithCustomFunction_GeneratesCorrectFunctionCall()
    {
        // Arrange
        var stack = new TerraformStack { Name = "test" };
        var arg1 = "arg1";
        var arg2 = "arg2";

        var output = new TerraformOutput("custom")
        {
            Value = Tf.Functions.Function<string, string>("custom_func", arg1, arg2)
        };
        stack.Add(output);

        // Act
        var hcl = stack.ToHcl();

        // Assert
        return Verify(hcl);
    }
}

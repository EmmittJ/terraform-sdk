namespace EmmittJ.Terraform.Sdk;

using System.Runtime.CompilerServices;

/// <summary>
/// Static helper class for Terraform built-in functions and type constraints.
/// Provides convenient access to Terraform functions and type system.
/// This class is partial to allow provider-specific function extensions.
/// </summary>
public static partial class Tf
{
    /// <summary>
    /// Terraform type constraint helpers.
    /// </summary>
    public static class Types
    {
        /// <summary>
        /// String type constraint.
        /// </summary>
        public const string String = "string";

        /// <summary>
        /// Number type constraint.
        /// </summary>
        public const string Number = "number";

        /// <summary>
        /// Boolean type constraint.
        /// </summary>
        public const string Bool = "bool";

        /// <summary>
        /// Any type constraint.
        /// </summary>
        public const string Any = "any";

        /// <summary>
        /// Creates a list type constraint.
        /// </summary>
        /// <param name="elementType">The type of elements in the list.</param>
        /// <returns>A list type constraint string.</returns>
        public static string List(string elementType) => $"list({elementType})";

        /// <summary>
        /// Creates a set type constraint.
        /// </summary>
        /// <param name="elementType">The type of elements in the set.</param>
        /// <returns>A set type constraint string.</returns>
        public static string Set(string elementType) => $"set({elementType})";

        /// <summary>
        /// Creates a map type constraint.
        /// </summary>
        /// <param name="elementType">The type of values in the map.</param>
        /// <returns>A map type constraint string.</returns>
        public static string Map(string elementType) => $"map({elementType})";

        /// <summary>
        /// Creates an object type constraint.
        /// </summary>
        /// <param name="attributes">The attributes of the object as (name, type) pairs.</param>
        /// <returns>An object type constraint string.</returns>
        public static string Object(params (string Name, string Type)[] attributes)
        {
            var props = string.Join(", ", attributes.Select(a => $"{a.Name} = {a.Type}"));
            return $"object({{{props}}})";
        }

        /// <summary>
        /// Creates a tuple type constraint.
        /// </summary>
        /// <param name="elementTypes">The types of elements in the tuple.</param>
        /// <returns>A tuple type constraint string.</returns>
        public static string Tuple(params string[] elementTypes)
        {
            return $"tuple([{string.Join(", ", elementTypes)}])";
        }
    }

    /// <summary>
    /// Terraform built-in functions.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Calculates a subnet address within a given IP network address prefix.
        /// cidrsubnet(prefix, newbits, netnum)
        /// </summary>
        /// <param name="prefix">The IP network address prefix (e.g., "10.0.0.0/16").</param>
        /// <param name="newbits">The number of additional bits to extend the prefix.</param>
        /// <param name="netnum">The subnet number.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> CidrSubnet(TerraformValue<string> prefix, TerraformValue<int> newbits, TerraformValue<int> netnum)
        {
            return TerraformValue<string>.Lazy(ctx =>
            {
                var prefixExpr = (TerraformExpression)prefix.ResolveNodes(ctx).First();
                var newbitsExpr = (TerraformExpression)newbits.ResolveNodes(ctx).First();
                var netnumExpr = (TerraformExpression)netnum.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("cidrsubnet", prefixExpr, newbitsExpr, netnumExpr)];
            });
        }

        /// <summary>
        /// Returns the number of elements in a list.
        /// length(value)
        /// </summary>
        /// <param name="list">The list to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformList<T> list)
        {
            return TerraformValue<int>.Lazy(ctx =>
            {
                var listExpr = (TerraformExpression)list.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("length", listExpr)];
            });
        }

        /// <summary>
        /// Returns the number of elements in a map.
        /// length(value)
        /// </summary>
        /// <param name="map">The map to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformMap<T> map)
        {
            return TerraformValue<int>.Lazy(ctx =>
            {
                var mapExpr = (TerraformExpression)map.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("length", mapExpr)];
            });
        }

        /// <summary>
        /// Returns the number of elements in a set.
        /// length(value)
        /// </summary>
        /// <param name="set">The set to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformSet<T> set)
        {
            return TerraformValue<int>.Lazy(ctx =>
            {
                var setExpr = (TerraformExpression)set.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("length", setExpr)];
            });
        }

        /// <summary>
        /// Returns the number of characters in a string.
        /// length(value)
        /// </summary>
        /// <param name="str">The string to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length(TerraformValue<string> str)
        {
            return TerraformValue<int>.Lazy(ctx =>
            {
                var strExpr = (TerraformExpression)str.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("length", strExpr)];
            });
        }

        /// <summary>
        /// Returns an element from a list at the given index.
        /// element(list, index)
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="index">The index.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<T> Element<T>(TerraformList<T> list, TerraformValue<int> index)
        {
            return TerraformValue<T>.Lazy(ctx =>
            {
                var listExpr = (TerraformExpression)list.ResolveNodes(ctx).First();
                var indexExpr = (TerraformExpression)index.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("element", listExpr, indexExpr)];
            });
        }

        /// <summary>
        /// Joins a list of strings with a delimiter.
        /// join(separator, list)
        /// </summary>
        /// <param name="separator">The separator string.</param>
        /// <param name="list">The list of strings to join.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> Join(TerraformValue<string> separator, TerraformList<string> list)
        {
            return TerraformValue<string>.Lazy(ctx =>
            {
                var separatorExpr = (TerraformExpression)separator.ResolveNodes(ctx).First();
                var listExpr = (TerraformExpression)list.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("join", separatorExpr, listExpr)];
            });
        }

        /// <summary>
        /// Formats a string with the given arguments.
        /// format(spec, values...)
        /// </summary>
        /// <param name="formatString">The format string.</param>
        /// <param name="arguments">The arguments to format.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> Format<T>(TerraformValue<string> formatString, params TerraformValue<T>[] arguments)
        {
            return TerraformValue<string>.Lazy(ctx =>
            {
                var allArgs = new TerraformExpression[arguments.Length + 1];
                allArgs[0] = (TerraformExpression)formatString.ResolveNodes(ctx).First();
                for (int i = 0; i < arguments.Length; i++)
                {
                    allArgs[i + 1] = (TerraformExpression)arguments[i].ResolveNodes(ctx).First();
                }
                return [TerraformExpressionExtensions.Call("format", allArgs)];
            });
        }

        /// <summary>
        /// Looks up a value in a map.
        /// lookup(map, key, default)
        /// </summary>
        /// <param name="map">The map to look up in.</param>
        /// <param name="key">The key to look up.</param>
        /// <param name="defaultValue">The default value if the key is not found (optional).</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<TValue> Lookup<TValue>(TerraformMap<TValue> map, TerraformValue<string> key, TerraformValue<TValue>? defaultValue = null)
        {
            return TerraformValue<TValue>.Lazy(ctx =>
            {
                var mapExpr = (TerraformExpression)map.ResolveNodes(ctx).First();
                var keyExpr = (TerraformExpression)key.ResolveNodes(ctx).First();
                if (defaultValue is null)
                {
                    return [TerraformExpressionExtensions.Call("lookup", mapExpr, keyExpr)];
                }
                else
                {
                    var defaultExpr = (TerraformExpression)defaultValue.ResolveNodes(ctx).First();
                    return [TerraformExpressionExtensions.Call("lookup", mapExpr, keyExpr, defaultExpr)];
                }
            });
        }

        /// <summary>
        /// Concatenates multiple lists into a single list.
        /// concat(lists...)
        /// </summary>
        /// <param name="lists">The lists to concatenate.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> Concat<T>(params TerraformList<T>[] lists)
        {
            return TerraformList<T>.Lazy(ctx =>
            {
                var expressions = new TerraformExpression[lists.Length];
                for (int i = 0; i < lists.Length; i++)
                {
                    expressions[i] = (TerraformExpression)lists[i].ResolveNodes(ctx).First();
                }
                return [TerraformExpressionExtensions.Call("concat", expressions)];
            });
        }

        /// <summary>
        /// Reads the contents of a file and returns it as a string.
        /// file(path)
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> File(TerraformValue<string> path)
        {
            return TerraformValue<string>.Lazy(ctx =>
            {
                var pathExpr = (TerraformExpression)path.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("file", pathExpr)];
            });
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max)
        /// </summary>
        /// <param name="max">The maximum value (exclusive).</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<int> Range(TerraformValue<int> max)
        {
            return TerraformList<int>.Lazy(ctx =>
            {
                var maxExpr = (TerraformExpression)max.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("range", maxExpr)];
            });
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(start, limit)
        /// </summary>
        /// <param name="start">The starting value (inclusive).</param>
        /// <param name="limit">The limit value (exclusive).</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<int> Range(TerraformValue<int> start, TerraformValue<int> limit)
        {
            return TerraformList<int>.Lazy(ctx =>
            {
                var startExpr = (TerraformExpression)start.ResolveNodes(ctx).First();
                var limitExpr = (TerraformExpression)limit.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("range", startExpr, limitExpr)];
            });
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(start, limit, step)
        /// </summary>
        /// <param name="start">The starting value (inclusive).</param>
        /// <param name="limit">The limit value (exclusive).</param>
        /// <param name="step">The step value.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<int> Range(TerraformValue<int> start, TerraformValue<int> limit, TerraformValue<int> step)
        {
            return TerraformList<int>.Lazy(ctx =>
            {
                var startExpr = (TerraformExpression)start.ResolveNodes(ctx).First();
                var limitExpr = (TerraformExpression)limit.ResolveNodes(ctx).First();
                var stepExpr = (TerraformExpression)step.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("range", startExpr, limitExpr, stepExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a string.
        /// tostring(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> ToString<T>(TerraformValue<T> value)
        {
            return TerraformValue<string>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tostring", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a number.
        /// tonumber(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<double> ToNumber<T>(TerraformValue<T> value)
        {
            return TerraformValue<double>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tonumber", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a boolean.
        /// tobool(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<bool> ToBool<T>(TerraformValue<T> value)
        {
            return TerraformValue<bool>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tobool", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a list.
        /// tolist(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> ToList<T>(TerraformValue<T> value)
        {
            return TerraformList<T>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tolist", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a set to a list.
        /// tolist(value)
        /// </summary>
        /// <param name="set">The set to convert.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> ToList<T>(TerraformSet<T> set)
        {
            return TerraformList<T>.Lazy(ctx =>
            {
                var setExpr = (TerraformExpression)set.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tolist", setExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a map.
        /// tomap(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformMap wrapping the function call.</returns>
        public static TerraformMap<T> ToMap<T>(TerraformValue<T> value)
        {
            return TerraformMap<T>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("tomap", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a value to a set.
        /// toset(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformSet wrapping the function call.</returns>
        public static TerraformSet<T> ToSet<T>(TerraformValue<T> value)
        {
            return TerraformSet<T>.Lazy(ctx =>
            {
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("toset", valueExpr)];
            });
        }

        /// <summary>
        /// Converts a list to a set.
        /// toset(value)
        /// </summary>
        /// <param name="list">The list to convert.</param>
        /// <returns>A TerraformSet wrapping the function call.</returns>
        public static TerraformSet<T> ToSet<T>(TerraformList<T> list)
        {
            return TerraformSet<T>.Lazy(ctx =>
            {
                var listExpr = (TerraformExpression)list.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("toset", listExpr)];
            });
        }

        /// <summary>
        /// Merges multiple maps into a single map.
        /// merge(maps...)
        /// </summary>
        /// <param name="maps">The maps to merge.</param>
        /// <returns>A TerraformMap wrapping the function call.</returns>
        public static TerraformMap<T> Merge<T>(params TerraformMap<T>[] maps)
        {
            return TerraformMap<T>.Lazy(ctx =>
            {
                var expressions = new TerraformExpression[maps.Length];
                for (int i = 0; i < maps.Length; i++)
                {
                    expressions[i] = (TerraformExpression)maps[i].ResolveNodes(ctx).First();
                }
                return [TerraformExpressionExtensions.Call("merge", expressions)];
            });
        }

        /// <summary>
        /// Returns the index of a value in a list.
        /// index(list, value)
        /// </summary>
        /// <param name="list">The list to search.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Index<T>(TerraformList<T> list, TerraformValue<T> value)
        {
            return TerraformValue<int>.Lazy(ctx =>
            {
                var listExpr = (TerraformExpression)list.ResolveNodes(ctx).First();
                var valueExpr = (TerraformExpression)value.ResolveNodes(ctx).First();
                return [TerraformExpressionExtensions.Call("index", listExpr, valueExpr)];
            });
        }

        /// <summary>
        /// Calls a Terraform function by name with the given arguments.
        /// This is an escape hatch for functions not explicitly supported.
        /// </summary>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<TResult> Function<TResult, TArg>(string functionName, params TerraformValue<TArg>[] arguments)
        {
            return TerraformValue<TResult>.Lazy(ctx =>
            {
                var expressions = new TerraformExpression[arguments.Length];
                for (int i = 0; i < arguments.Length; i++)
                {
                    expressions[i] = (TerraformExpression)arguments[i].ResolveNodes(ctx).First();
                }
                return [TerraformExpressionExtensions.Call(functionName, expressions)];
            });
        }
    }

    /// <summary>
    /// Helper methods for common Terraform patterns.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Creates a reference to a local value.
        /// </summary>
        /// <param name="name">The name of the local value.</param>
        /// <returns>An identifier expression for the local.</returns>
        public static TerraformExpression Local(string name) => TerraformExpression.Identifier($"local.{name}");

        /// <summary>
        /// Creates a reference to each.value (for use in for_each blocks).
        /// </summary>
        public static TerraformExpression EachValue => TerraformExpression.Identifier("each.value");

        /// <summary>
        /// Creates a reference to each.key (for use in for_each blocks).
        /// </summary>
        public static TerraformExpression EachKey => TerraformExpression.Identifier("each.key");

        /// <summary>
        /// Creates a new TerraformMapExpression for building HCL maps.
        /// </summary>
        /// <returns>A new TerraformMapExpression.</returns>
        public static TerraformMapExpression Object() => new TerraformMapExpression();

        /// <summary>
        /// Creates a map expression with a fluent builder API.
        /// </summary>
        /// <param name="configure">Action to configure the object.</param>
        /// <returns>A configured object expression.</returns>
        public static TerraformMapExpression Object(Action<TerraformMapExpression> configure)
        {
            var obj = new TerraformMapExpression();
            configure(obj);
            return obj;
        }
    }

    /// <summary>
    /// Creates a Terraform string template expression from an interpolated string.
    /// Enables natural C# syntax for building Terraform string templates with embedded expressions.
    /// Supports format specifiers for Terraform functions (e.g., :jsonencode, :sensitive, :base64encode).
    /// </summary>
    /// <param name="handler">The interpolated string handler.</param>
    /// <returns>A TerraformExpression representing the string template.</returns>
    /// <example>
    /// <code>
    /// // Variable reference
    /// Tf.Interpolate($"prefix-{variable}-suffix")  // → "prefix-${var.variable}-suffix"
    ///
    /// // Local value reference
    /// Tf.Interpolate($"{locals["name"]}-web")      // → "${local.name}-web"
    ///
    /// // Resource attribute reference
    /// Tf.Interpolate($"vpc-{vpc["id"]}")           // → "vpc-${aws_vpc.main.id}"
    ///
    /// // Multiple expressions
    /// Tf.Interpolate($"{region}/{environment}")    // → "${var.region}/${var.environment}"
    ///
    /// // With format specifiers
    /// Tf.Interpolate($"{data:jsonencode}")         // → "${jsonencode(var.data)}"
    /// Tf.Interpolate($"{password:sensitive}")      // → "${sensitive(var.password)}"
    /// Tf.Interpolate($"{value:base64encode}")      // → "${base64encode(var.value)}"
    /// </code>
    /// </example>
    public static TerraformExpression Interpolate(TerraformInterpolatedStringHandler handler)
    {
        return handler.GetExpression();
    }
}





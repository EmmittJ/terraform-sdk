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
    /// Provides convenient access to <see cref="TerraformTypeExpression"/> factory methods.
    /// </summary>
    /// <remarks>
    /// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types"/></para>
    /// </remarks>
    public static class Types
    {
        /// <summary>
        /// String type constraint.
        /// </summary>
        public static TerraformTypeExpression String => TerraformTypeExpression.String;

        /// <summary>
        /// Number type constraint.
        /// </summary>
        public static TerraformTypeExpression Number => TerraformTypeExpression.Number;

        /// <summary>
        /// Boolean type constraint.
        /// </summary>
        public static TerraformTypeExpression Bool => TerraformTypeExpression.Bool;

        /// <summary>
        /// Any type constraint. Accepts any type.
        /// </summary>
        public static TerraformTypeExpression Any => TerraformTypeExpression.Any;

        /// <summary>
        /// Creates a list type constraint.
        /// </summary>
        /// <param name="elementType">The type of elements in the list.</param>
        /// <returns>A list type constraint.</returns>
        public static TerraformTypeExpression List(TerraformTypeExpression elementType)
            => TerraformTypeExpression.List(elementType);

        /// <summary>
        /// Creates a set type constraint.
        /// </summary>
        /// <param name="elementType">The type of elements in the set.</param>
        /// <returns>A set type constraint.</returns>
        public static TerraformTypeExpression Set(TerraformTypeExpression elementType)
            => TerraformTypeExpression.Set(elementType);

        /// <summary>
        /// Creates a map type constraint.
        /// </summary>
        /// <param name="valueType">The type of values in the map.</param>
        /// <returns>A map type constraint.</returns>
        public static TerraformTypeExpression Map(TerraformTypeExpression valueType)
            => TerraformTypeExpression.Map(valueType);

        /// <summary>
        /// Creates an object type constraint.
        /// </summary>
        /// <param name="attributes">The attributes of the object as (name, type) pairs.</param>
        /// <returns>An object type constraint.</returns>
        public static TerraformTypeExpression Object(params (string Name, TerraformTypeExpression Type)[] attributes)
            => TerraformTypeExpression.Object(attributes);

        /// <summary>
        /// Creates a tuple type constraint.
        /// </summary>
        /// <param name="elementTypes">The types of elements in the tuple.</param>
        /// <returns>A tuple type constraint.</returns>
        public static TerraformTypeExpression Tuple(params TerraformTypeExpression[] elementTypes)
            => TerraformTypeExpression.Tuple(elementTypes);
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
            return Call<string>("cidrsubnet", prefix, newbits, netnum);
        }

        /// <summary>
        /// Returns the number of elements in a list.
        /// length(value)
        /// </summary>
        /// <param name="list">The list to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformList<T> list)
        {
            return Call<int>("length", list);
        }

        /// <summary>
        /// Returns the number of elements in a map.
        /// length(value)
        /// </summary>
        /// <param name="map">The map to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformMap<T> map)
        {
            return Call<int>("length", map);
        }

        /// <summary>
        /// Returns the number of elements in a set.
        /// length(value)
        /// </summary>
        /// <param name="set">The set to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length<T>(TerraformSet<T> set)
        {
            return Call<int>("length", set);
        }

        /// <summary>
        /// Returns the number of characters in a string.
        /// length(value)
        /// </summary>
        /// <param name="str">The string to measure.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<int> Length(TerraformValue<string> str)
        {
            return Call<int>("length", str);
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
            return Call<T>("element", list, index);
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
            return Call<string>("join", [separator, list]);
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
            return Call<string>("format", [formatString, .. arguments]);
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
            return Call<TValue>("lookup", map, key, defaultValue);
        }

        /// <summary>
        /// Concatenates multiple lists into a single list.
        /// concat(lists...)
        /// </summary>
        /// <param name="lists">The lists to concatenate.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> Concat<T>(params TerraformList<T>[] lists)
        {
            return CallList<T>("concat", lists);
        }

        /// <summary>
        /// Reads the contents of a file and returns it as a string.
        /// file(path)
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> File(TerraformValue<string> path)
        {
            return Call<string>("file", path);
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max)
        /// </summary>
        /// <param name="max">The maximum value (exclusive).</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<int> Range(TerraformValue<int> max)
        {
            return CallList<int>("range", max);
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
            return CallList<int>("range", start, limit);
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
            return CallList<int>("range", start, limit, step);
        }

        /// <summary>
        /// Converts a value to a string.
        /// tostring(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<string> ToString<T>(TerraformValue<T> value)
        {
            return Call<string>("tostring", value);
        }

        /// <summary>
        /// Converts a value to a number.
        /// tonumber(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<double> ToNumber<T>(TerraformValue<T> value)
        {
            return Call<double>("tonumber", value);
        }

        /// <summary>
        /// Converts a value to a boolean.
        /// tobool(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        public static TerraformValue<bool> ToBool<T>(TerraformValue<T> value)
        {
            return Call<bool>("tobool", value);
        }

        /// <summary>
        /// Converts a value to a list.
        /// tolist(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> ToList<T>(TerraformValue<T> value)
        {
            return CallList<T>("tolist", value);
        }

        /// <summary>
        /// Converts a set to a list.
        /// tolist(value)
        /// </summary>
        /// <param name="set">The set to convert.</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<T> ToList<T>(TerraformSet<T> set)
        {
            return CallList<T>("tolist", set);
        }

        /// <summary>
        /// Converts a value to a map.
        /// tomap(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformMap wrapping the function call.</returns>
        public static TerraformMap<T> ToMap<T>(TerraformValue<T> value)
        {
            return CallMap<T>("tomap", value);
        }

        /// <summary>
        /// Converts a value to a set.
        /// toset(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A TerraformSet wrapping the function call.</returns>
        public static TerraformSet<T> ToSet<T>(TerraformValue<T> value)
        {
            return CallSet<T>("toset", value);
        }

        /// <summary>
        /// Converts a list to a set.
        /// toset(value)
        /// </summary>
        /// <param name="list">The list to convert.</param>
        /// <returns>A TerraformSet wrapping the function call.</returns>
        public static TerraformSet<T> ToSet<T>(TerraformList<T> list)
        {
            return CallSet<T>("toset", list);
        }

        /// <summary>
        /// Merges multiple maps into a single map.
        /// merge(maps...)
        /// </summary>
        /// <param name="maps">The maps to merge.</param>
        /// <returns>A TerraformMap wrapping the function call.</returns>
        public static TerraformMap<T> Merge<T>(params TerraformMap<T>[] maps)
        {
            return CallMap<T>("merge", maps);
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
            return Call<int>("index", list, value);
        }

        /// <summary>
        /// Replaces all occurrences of a substring in a string.
        /// replace(string, search, replace)
        /// </summary>
        /// <param name="str">The string to search in.</param>
        /// <param name="search">The substring to search for.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        /// <remarks>
        /// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/functions/replace"/></para>
        /// </remarks>
        /// <example>
        /// <code>
        /// // Remove a prefix from a string
        /// var imageName = Tf.Functions.Replace(fullImagePath, Tf.Interpolate($"{registryUrl}/"), "");
        /// // → replace(var.full_image_path, "${var.registry_url}/", "")
        /// </code>
        /// </example>
        public static TerraformValue<string> Replace(TerraformValue<string> str, TerraformValue<string> search, TerraformValue<string> replacement)
        {
            return Call<string>("replace", str, search, replacement);
        }

        /// <summary>
        /// Calls a Terraform function by name with the given arguments.
        /// This is an escape hatch for functions not explicitly supported.
        /// Arguments can be any resolvable type (TerraformValue, TerraformList, TerraformExpression, etc.).
        /// </summary>
        /// <typeparam name="TResult">The expected result type.</typeparam>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function (any ITerraformResolvable).</param>
        /// <returns>A TerraformValue wrapping the function call.</returns>
        /// <example>
        /// <code>
        /// // Call format with mixed argument types
        /// var result = Tf.Functions.Call&lt;string&gt;("format", "Host=%s;Port=%s", hostVar, portVar);
        ///
        /// // Call coalesce with multiple values
        /// var value = Tf.Functions.Call&lt;string&gt;("coalesce", primary, secondary, "default");
        /// </code>
        /// </example>
        public static TerraformValue<TResult> Call<TResult>(string functionName, params ITerraformResolvable?[] arguments)
        {
            return TerraformValue<TResult>.Lazy(ctx =>
            {
                var expressions = ResolveArguments(ctx, arguments);
                return [TerraformExpressionExtensions.Call(functionName, expressions)];
            });
        }

        /// <summary>
        /// Calls a Terraform function by name with the given arguments, returning a list.
        /// This is an escape hatch for functions not explicitly supported.
        /// </summary>
        /// <typeparam name="TResult">The expected element type of the result list.</typeparam>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function (any ITerraformResolvable).</param>
        /// <returns>A TerraformList wrapping the function call.</returns>
        public static TerraformList<TResult> CallList<TResult>(string functionName, params ITerraformResolvable?[] arguments)
        {
            return TerraformList<TResult>.Lazy(ctx =>
            {
                var expressions = ResolveArguments(ctx, arguments);
                return [TerraformExpressionExtensions.Call(functionName, expressions)];
            });
        }

        /// <summary>
        /// Calls a Terraform function by name with the given arguments, returning a map.
        /// This is an escape hatch for functions not explicitly supported.
        /// </summary>
        /// <typeparam name="TResult">The expected value type of the result map.</typeparam>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function (any ITerraformResolvable).</param>
        /// <returns>A TerraformMap wrapping the function call.</returns>
        public static TerraformMap<TResult> CallMap<TResult>(string functionName, params ITerraformResolvable?[] arguments)
        {
            return TerraformMap<TResult>.Lazy(ctx =>
            {
                var expressions = ResolveArguments(ctx, arguments);
                return [TerraformExpressionExtensions.Call(functionName, expressions)];
            });
        }

        /// <summary>
        /// Calls a Terraform function by name with the given arguments, returning a set.
        /// This is an escape hatch for functions not explicitly supported.
        /// </summary>
        /// <typeparam name="TResult">The expected element type of the result set.</typeparam>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function (any ITerraformResolvable).</param>
        /// <returns>A TerraformSet wrapping the function call.</returns>
        public static TerraformSet<TResult> CallSet<TResult>(string functionName, params ITerraformResolvable?[] arguments)
        {
            return TerraformSet<TResult>.Lazy(ctx =>
            {
                var expressions = ResolveArguments(ctx, arguments);
                return [TerraformExpressionExtensions.Call(functionName, expressions)];
            });
        }

        /// <summary>
        /// Resolves arguments to TerraformSyntaxNode array for function calls.
        /// </summary>
        private static TerraformSyntaxNode[] ResolveArguments(ITerraformContext ctx, ITerraformResolvable?[] arguments)
        {
            var nodes = new List<TerraformSyntaxNode>();
            for (var i = 0; i < arguments.Length; i++)
            {
                if (arguments[i]?.ResolveNodes(ctx) is { } args)
                {
                    nodes.AddRange(args);
                }
            }
            return [.. nodes];
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





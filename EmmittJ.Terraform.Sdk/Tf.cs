namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Static helper class for Terraform built-in functions and type constraints.
/// Provides convenient access to Terraform functions and type system.
/// </summary>
public static class Tf
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
        /// <returns>A function call expression.</returns>
        public static TerraformExpression CidrSubnet(TerraformExpression prefix, int newbits, TerraformExpression netnum)
        {
            return TerraformExpressionExtensions.Call("cidrsubnet", prefix, TerraformExpression.Literal(newbits), netnum);
        }

        /// <summary>
        /// Calculates a subnet address within a given IP network address prefix.
        /// cidrsubnet(prefix, newbits, netnum)
        /// </summary>
        /// <param name="prefix">The IP network address prefix (e.g., "10.0.0.0/16").</param>
        /// <param name="newbits">The number of additional bits to extend the prefix.</param>
        /// <param name="netnum">The subnet number.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression CidrSubnet(string prefix, int newbits, int netnum)
        {
            return TerraformExpressionExtensions.Call("cidrsubnet",
                TerraformExpression.Literal(prefix),
                TerraformExpression.Literal(newbits),
                TerraformExpression.Literal(netnum));
        }

        /// <summary>
        /// Returns the number of elements in a list, map, or string.
        /// length(value)
        /// </summary>
        /// <param name="collection">The collection to measure.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Length(TerraformExpression collection)
        {
            return TerraformExpressionExtensions.Call("length", collection);
        }

        /// <summary>
        /// Returns an element from a list at the given index.
        /// element(list, index)
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="index">The index.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Element(TerraformExpression list, TerraformExpression index)
        {
            return TerraformExpressionExtensions.Call("element", list, index);
        }

        /// <summary>
        /// Returns an element from a list at the given index.
        /// element(list, index)
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="index">The index.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Element(TerraformExpression list, int index)
        {
            return TerraformExpressionExtensions.Call("element", list, TerraformExpression.Literal(index));
        }

        /// <summary>
        /// Joins a list of strings with a delimiter.
        /// join(separator, list)
        /// </summary>
        /// <param name="separator">The separator string.</param>
        /// <param name="list">The list of strings to join.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Join(string separator, TerraformExpression list)
        {
            return TerraformExpressionExtensions.Call("join", TerraformExpression.Literal(separator), list);
        }

        /// <summary>
        /// Formats a string with the given arguments.
        /// format(spec, values...)
        /// </summary>
        /// <param name="formatString">The format string.</param>
        /// <param name="arguments">The arguments to format.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Format(string formatString, params TerraformExpression[] arguments)
        {
            var allArgs = new TerraformExpression[arguments.Length + 1];
            allArgs[0] = TerraformExpression.Literal(formatString);
            Array.Copy(arguments, 0, allArgs, 1, arguments.Length);
            return TerraformExpressionExtensions.Call("format", allArgs);
        }

        /// <summary>
        /// Looks up a value in a map.
        /// lookup(map, key, default)
        /// </summary>
        /// <param name="map">The map to look up in.</param>
        /// <param name="key">The key to look up.</param>
        /// <param name="defaultValue">The default value if the key is not found (optional).</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Lookup(TerraformExpression map, TerraformExpression key, TerraformExpression? defaultValue = null)
        {
            return defaultValue is null
                ? TerraformExpressionExtensions.Call("lookup", map, key)
                : TerraformExpressionExtensions.Call("lookup", map, key, defaultValue);
        }

        /// <summary>
        /// Looks up a value in a map.
        /// lookup(map, key, default)
        /// </summary>
        /// <param name="map">The map to look up in.</param>
        /// <param name="key">The key to look up.</param>
        /// <param name="defaultValue">The default value if the key is not found (optional).</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Lookup(TerraformExpression map, string key, TerraformExpression? defaultValue = null)
        {
            return defaultValue is null
                ? TerraformExpressionExtensions.Call("lookup", map, TerraformExpression.Literal(key))
                : TerraformExpressionExtensions.Call("lookup", map, TerraformExpression.Literal(key), defaultValue);
        }

        /// <summary>
        /// Concatenates multiple lists into a single list.
        /// concat(lists...)
        /// </summary>
        /// <param name="lists">The lists to concatenate.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Concat(params TerraformExpression[] lists)
        {
            return TerraformExpressionExtensions.Call("concat", lists);
        }

        /// <summary>
        /// Reads the contents of a file and returns it as a string.
        /// file(path)
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression File(string path)
        {
            return TerraformExpressionExtensions.Call("file", TerraformExpression.Literal(path));
        }

        /// <summary>
        /// Reads the contents of a file and returns it as a string.
        /// file(path)
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression File(TerraformExpression path)
        {
            return TerraformExpressionExtensions.Call("file", path);
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max) or range(start, limit) or range(start, limit, step)
        /// </summary>
        /// <param name="max">The maximum value (exclusive).</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Range(int max)
        {
            return TerraformExpressionExtensions.Call("range", TerraformExpression.Literal(max));
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max) or range(start, limit) or range(start, limit, step)
        /// </summary>
        /// <param name="max">The maximum value (exclusive).</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Range(TerraformExpression max)
        {
            return TerraformExpressionExtensions.Call("range", max);
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max) or range(start, limit) or range(start, limit, step)
        /// </summary>
        /// <param name="start">The starting value (inclusive).</param>
        /// <param name="limit">The limit value (exclusive).</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Range(int start, int limit)
        {
            return TerraformExpressionExtensions.Call("range",
                TerraformExpression.Literal(start),
                TerraformExpression.Literal(limit));
        }

        /// <summary>
        /// Returns a range of numbers.
        /// range(max) or range(start, limit) or range(start, limit, step)
        /// </summary>
        /// <param name="start">The starting value (inclusive).</param>
        /// <param name="limit">The limit value (exclusive).</param>
        /// <param name="step">The step value.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Range(int start, int limit, int step)
        {
            return TerraformExpressionExtensions.Call("range",
                TerraformExpression.Literal(start),
                TerraformExpression.Literal(limit),
                TerraformExpression.Literal(step));
        }

        /// <summary>
        /// Converts a value to a string.
        /// tostring(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToString(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("tostring", value);
        }

        /// <summary>
        /// Converts a value to a number.
        /// tonumber(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToNumber(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("tonumber", value);
        }

        /// <summary>
        /// Converts a value to a boolean.
        /// tobool(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToBool(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("tobool", value);
        }

        /// <summary>
        /// Converts a value to a list.
        /// tolist(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToList(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("tolist", value);
        }

        /// <summary>
        /// Converts a value to a map.
        /// tomap(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToMap(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("tomap", value);
        }

        /// <summary>
        /// Converts a value to a set.
        /// toset(value)
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression ToSet(TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("toset", value);
        }

        /// <summary>
        /// Merges multiple maps into a single map.
        /// merge(maps...)
        /// </summary>
        /// <param name="maps">The maps to merge.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Merge(params TerraformExpression[] maps)
        {
            return TerraformExpressionExtensions.Call("merge", maps);
        }

        /// <summary>
        /// Returns the index of a value in a list.
        /// index(list, value)
        /// </summary>
        /// <param name="list">The list to search.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Index(TerraformExpression list, TerraformExpression value)
        {
            return TerraformExpressionExtensions.Call("index", list, value);
        }

        /// <summary>
        /// <summary>
        /// Calls a Terraform function by name with the given arguments.
        /// This is an escape hatch for functions not explicitly supported.
        /// </summary>
        /// <param name="functionName">The name of the function.</param>
        /// <param name="arguments">The arguments to the function.</param>
        /// <returns>A function call expression.</returns>
        public static TerraformExpression Function(string functionName, params TerraformExpression[] arguments)
        {
            return TerraformExpressionExtensions.Call(functionName, arguments);
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
        /// Creates a new TerraformObject for building HCL objects.
        /// </summary>
        /// <returns>A new TerraformObject.</returns>
        public static TerraformObjectExpression Object() => new TerraformObjectExpression();

        /// <summary>
        /// Creates an object expression with a fluent builder API.
        /// </summary>
        /// <param name="configure">Action to configure the object.</param>
        /// <returns>A configured object expression.</returns>
        public static TerraformObjectExpression Object(Action<TerraformObjectExpression> configure)
        {
            var obj = new TerraformObjectExpression();
            configure(obj);
            return obj;
        }
    }
}



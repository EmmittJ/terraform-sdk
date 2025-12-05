using System.Collections.Immutable;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the origin path of a Terraform value, tracking where it came from.
/// Lineage is immutable - extending a lineage creates a new instance.
/// </summary>
/// <remarks>
/// <para>
/// Every value in the SDK can carry a lineage that describes its full path.
/// When a value has a lineage, it resolves to a reference expression in HCL.
/// When a value has no lineage, it resolves to a literal.
/// </para>
/// <para>
/// Lineage enables natural property access patterns like <c>containerApp.Ingress[0].Fqdn</c>
/// where each access extends the lineage to build the full reference path.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // When a resource is added to a stack, it gets initial lineage
/// var vpc = stack.Add(new AwsVpc("main"));
/// // vpc.Lineage = TerraformLineage([IdentifierSegment("aws_vpc.main")])
///
/// // Accessing properties extends the lineage
/// var vpcId = vpc.Id;
/// // vpcId.Lineage = TerraformLineage([IdentifierSegment("aws_vpc.main"), MemberSegment("id")])
/// // Resolves to: aws_vpc.main.id
/// </code>
/// </example>
public sealed record TerraformLineage
{
    /// <summary>
    /// Gets the path segments that describe the location of this value.
    /// </summary>
    public ImmutableArray<TerraformPathSegment> Path { get; }

    /// <summary>
    /// Creates a new lineage with the specified path.
    /// </summary>
    /// <param name="path">The path segments.</param>
    public TerraformLineage(ImmutableArray<TerraformPathSegment> path)
    {
        Path = path;
    }

    /// <summary>
    /// Creates a new lineage with a single identifier segment.
    /// </summary>
    /// <param name="identifier">The initial identifier (e.g., "aws_vpc.main", "var", "local").</param>
    public TerraformLineage(string identifier)
        : this([new IdentifierSegment(identifier)])
    {
    }

    /// <summary>
    /// Creates a new lineage with the member segment appended.
    /// </summary>
    /// <param name="name">The member name (e.g., "id", "tags", "ingress").</param>
    /// <returns>A new lineage with the extended path.</returns>
    public TerraformLineage WithMember(string name)
        => new(Path.Add(new MemberSegment(name)));

    /// <summary>
    /// Creates a new lineage with an index segment appended.
    /// </summary>
    /// <param name="index">The numeric index (e.g., 0, 1, 2).</param>
    /// <returns>A new lineage with the extended path.</returns>
    public TerraformLineage WithIndex(int index)
        => new(Path.Add(new IndexSegment(index)));

    /// <summary>
    /// Creates a new lineage with a key segment appended.
    /// </summary>
    /// <param name="key">The string key (e.g., "Environment", "us-west-2").</param>
    /// <returns>A new lineage with the extended path.</returns>
    public TerraformLineage WithKey(string key)
        => new(Path.Add(new KeySegment(key)));

    /// <summary>
    /// Builds the HCL reference expression from this lineage.
    /// </summary>
    /// <returns>A TerraformExpression representing this lineage as an HCL reference.</returns>
    /// <example>
    /// <code>
    /// // For a lineage with path [IdentifierSegment("aws_vpc.main"), MemberSegment("id")]
    /// var expr = lineage.BuildExpression();
    /// // Returns an expression that renders as: aws_vpc.main.id
    /// </code>
    /// </example>
    public TerraformExpression BuildExpression()
    {
        if (Path.IsEmpty)
        {
            throw new InvalidOperationException("Cannot build expression from empty lineage path.");
        }

        TerraformExpression? result = null;
        foreach (var segment in Path)
        {
            result = segment.Apply(result);
        }

        return result ?? throw new InvalidOperationException("Failed to build expression from lineage path.");
    }

    /// <summary>
    /// Returns the HCL representation of this lineage.
    /// </summary>
    public override string ToString()
    {
        if (Path.IsEmpty)
        {
            return string.Empty;
        }
        return BuildExpression().ToHcl(TerraformContext.Temporary());
    }
}

/// <summary>
/// Base class for path segments in a <see cref="TerraformLineage"/>.
/// Each segment represents one level of navigation in the Terraform reference path.
/// </summary>
public abstract record TerraformPathSegment
{
    /// <summary>
    /// Applies this segment to an existing expression to extend the path.
    /// </summary>
    /// <param name="source">The source expression to extend, or null for the root segment.</param>
    /// <returns>A new expression with this segment applied.</returns>
    public abstract TerraformExpression Apply(TerraformExpression? source);
}

/// <summary>
/// Represents the first segment of a lineage path - the block identifier.
/// </summary>
/// <param name="Identifier">The identifier string (e.g., "aws_vpc.main", "var", "local", "data.aws_ami.ubuntu").</param>
/// <remarks>
/// <para>
/// For resources: "aws_vpc.main" (type.name)
/// For data sources: "data.aws_ami.ubuntu" (data.type.name)
/// For variables: "var" (then member access for the variable name)
/// For locals: "local" (then member access for the local name)
/// </para>
/// </remarks>
public sealed record IdentifierSegment(string Identifier) : TerraformPathSegment
{
    /// <inheritdoc />
    public override TerraformExpression Apply(TerraformExpression? source)
        => TerraformExpression.Identifier(Identifier);
}

/// <summary>
/// Represents a dot-access member segment (e.g., ".id", ".tags", ".ingress").
/// </summary>
/// <param name="Name">The member name to access.</param>
public sealed record MemberSegment(string Name) : TerraformPathSegment
{
    /// <inheritdoc />
    public override TerraformExpression Apply(TerraformExpression? source)
        => source is null
            ? throw new InvalidOperationException("MemberSegment requires a source expression.")
            : source[Name];
}

/// <summary>
/// Represents a numeric index segment (e.g., "[0]", "[1]").
/// </summary>
/// <param name="Index">The numeric index.</param>
public sealed record IndexSegment(int Index) : TerraformPathSegment
{
    /// <inheritdoc />
    public override TerraformExpression Apply(TerraformExpression? source)
        => source is null
            ? throw new InvalidOperationException("IndexSegment requires a source expression.")
            : TerraformExpression.Index(source, TerraformExpression.Literal(Index));
}

/// <summary>
/// Represents a string key segment (e.g., ["key"], ["Environment"]).
/// </summary>
/// <param name="Key">The string key.</param>
public sealed record KeySegment(string Key) : TerraformPathSegment
{
    /// <inheritdoc />
    public override TerraformExpression Apply(TerraformExpression? source)
        => source is null
            ? throw new InvalidOperationException("KeySegment requires a source expression.")
            : TerraformExpression.Index(source, TerraformExpression.Literal(Key));
}

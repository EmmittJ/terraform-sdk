using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multi_region_properties in AwsDsqlCluster.
/// Nesting mode: list
/// </summary>
public class AwsDsqlClusterMultiRegionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_region_properties";

    /// <summary>
    /// The clusters attribute.
    /// </summary>
    public TerraformSet<string> Clusters
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "clusters").ResolveNodes(ctx));
        set => SetArgument("clusters", value);
    }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    public TerraformValue<string>? WitnessRegion
    {
        get => new TerraformReference<string>(this, "witness_region");
        set => SetArgument("witness_region", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDsqlCluster.
/// Nesting mode: single
/// </summary>
public class AwsDsqlClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_dsql_cluster Terraform resource.
/// Manages a aws_dsql_cluster resource.
/// </summary>
public partial class AwsDsqlCluster(string name) : TerraformResource("aws_dsql_cluster", name)
{
    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool> ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    public TerraformValue<string> KmsEncryptionKey
    {
        get => new TerraformReference<string>(this, "kms_encryption_key");
        set => SetArgument("kms_encryption_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointServiceName
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_service_name");
    }

    /// <summary>
    /// MultiRegionProperties block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDsqlClusterMultiRegionPropertiesBlock>? MultiRegionProperties
    {
        get => GetArgument<TerraformList<AwsDsqlClusterMultiRegionPropertiesBlock>>("multi_region_properties");
        set => SetArgument("multi_region_properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDsqlClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDsqlClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

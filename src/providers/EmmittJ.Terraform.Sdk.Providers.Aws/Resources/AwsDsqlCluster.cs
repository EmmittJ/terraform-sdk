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
        get => GetArgument<TerraformSet<string>>("clusters") ?? CreateReference("clusters");
        set => SetArgument("clusters", value);
    }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    public TerraformValue<string>? WitnessRegion
    {
        get => GetArgument<TerraformValue<string>>("witness_region");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<bool>>("deletion_protection_enabled") ?? CreateReference("deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool> ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy") ?? CreateReference("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    public TerraformValue<string> KmsEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("kms_encryption_key") ?? CreateReference("kms_encryption_key");
        set => SetArgument("kms_encryption_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionDetails
        => CreateReference("encryption_details");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
        => CreateReference("identifier");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointServiceName
        => CreateReference("vpc_endpoint_service_name");

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

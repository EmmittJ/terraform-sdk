using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_global_cluster Terraform data source.
/// Retrieves information about a aws_rds_global_cluster.
/// </summary>
public partial class AwsRdsGlobalClusterDataSource(string name) : TerraformDataSource("aws_rds_global_cluster", name)
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformValue<string> EngineLifecycleSupport
    {
        get => new TerraformReference<string>(this, "engine_lifecycle_support");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Members
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "members").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}

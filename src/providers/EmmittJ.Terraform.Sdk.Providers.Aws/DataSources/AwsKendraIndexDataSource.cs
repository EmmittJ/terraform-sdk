using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kendra_index Terraform data source.
/// Retrieves information about a aws_kendra_index.
/// </summary>
public partial class AwsKendraIndexDataSource(string name) : TerraformDataSource("aws_kendra_index", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public TerraformMap<string> Tags
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
    /// The capacity_units attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CapacityUnits
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "capacity_units").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DocumentMetadataConfigurationUpdates
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "document_metadata_configuration_updates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => new TerraformReference<string>(this, "edition");
    }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IndexStatistics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "index_statistics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerSideEncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "server_side_encryption_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformValue<string> UserContextPolicy
    {
        get => new TerraformReference<string>(this, "user_context_policy");
    }

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserGroupResolutionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_group_resolution_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserTokenConfigurations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_token_configurations").ResolveNodes(ctx));
    }

}

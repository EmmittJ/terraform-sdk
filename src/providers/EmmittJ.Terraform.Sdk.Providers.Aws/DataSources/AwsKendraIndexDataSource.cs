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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
        => AsReference("arn");

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CapacityUnits
        => AsReference("capacity_units");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DocumentMetadataConfigurationUpdates
        => AsReference("document_metadata_configuration_updates");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string> Edition
        => AsReference("edition");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => AsReference("error_message");

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IndexStatistics
        => AsReference("index_statistics");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerSideEncryptionConfiguration
        => AsReference("server_side_encryption_configuration");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformValue<string> UserContextPolicy
        => AsReference("user_context_policy");

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserGroupResolutionConfiguration
        => AsReference("user_group_resolution_configuration");

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserTokenConfigurations
        => AsReference("user_token_configurations");

}

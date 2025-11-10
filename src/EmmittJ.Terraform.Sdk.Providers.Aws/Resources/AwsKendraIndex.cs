using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_units in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexCapacityUnitsBlock : TerraformBlock
{
    /// <summary>
    /// The query_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? QueryCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("query_capacity_units");
        set => WithProperty("query_capacity_units", value);
    }

    /// <summary>
    /// The storage_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity_units");
        set => WithProperty("storage_capacity_units", value);
    }

}

/// <summary>
/// Block type for document_metadata_configuration_updates in .
/// Nesting mode: set
/// </summary>
public class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexServerSideEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKendraIndexTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for user_group_resolution_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserGroupResolutionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The user_group_resolution_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserGroupResolutionMode is required")]
    public required TerraformProperty<string> UserGroupResolutionMode
    {
        get => GetProperty<TerraformProperty<string>>("user_group_resolution_mode");
        set => WithProperty("user_group_resolution_mode", value);
    }

}

/// <summary>
/// Block type for user_token_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserTokenConfigurationsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_kendra_index resource.
/// </summary>
public class AwsKendraIndex : TerraformResource
{
    public AwsKendraIndex(string name) : base("aws_kendra_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("error_message");
        this.DeclareOutput("index_statistics");
        this.DeclareOutput("status");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformProperty<string>? UserContextPolicy
    {
        get => GetProperty<TerraformProperty<string>>("user_context_policy");
        set => this.WithProperty("user_context_policy", value);
    }

    /// <summary>
    /// Block for capacity_units.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityUnits block(s) allowed")]
    public List<AwsKendraIndexCapacityUnitsBlock>? CapacityUnits
    {
        get => GetProperty<List<AwsKendraIndexCapacityUnitsBlock>>("capacity_units");
        set => this.WithProperty("capacity_units", value);
    }

    /// <summary>
    /// Block for document_metadata_configuration_updates.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 DocumentMetadataConfigurationUpdates block(s) allowed")]
    public HashSet<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>? DocumentMetadataConfigurationUpdates
    {
        get => GetProperty<HashSet<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>>("document_metadata_configuration_updates");
        set => this.WithProperty("document_metadata_configuration_updates", value);
    }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    public List<AwsKendraIndexServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetProperty<List<AwsKendraIndexServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => this.WithProperty("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKendraIndexTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKendraIndexTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_group_resolution_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserGroupResolutionConfiguration block(s) allowed")]
    public List<AwsKendraIndexUserGroupResolutionConfigurationBlock>? UserGroupResolutionConfiguration
    {
        get => GetProperty<List<AwsKendraIndexUserGroupResolutionConfigurationBlock>>("user_group_resolution_configuration");
        set => this.WithProperty("user_group_resolution_configuration", value);
    }

    /// <summary>
    /// Block for user_token_configurations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserTokenConfigurations block(s) allowed")]
    public List<AwsKendraIndexUserTokenConfigurationsBlock>? UserTokenConfigurations
    {
        get => GetProperty<List<AwsKendraIndexUserTokenConfigurationsBlock>>("user_token_configurations");
        set => this.WithProperty("user_token_configurations", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    public TerraformExpression IndexStatistics => this["index_statistics"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}

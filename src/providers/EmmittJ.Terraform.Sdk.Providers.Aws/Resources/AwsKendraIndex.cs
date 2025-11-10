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
        set => SetProperty("query_capacity_units", value);
    }

    /// <summary>
    /// The storage_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacityUnits
    {
        set => SetProperty("storage_capacity_units", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("kms_key_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("user_group_resolution_mode", value);
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
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKendraIndex : TerraformResource
{
    public AwsKendraIndex(string name) : base("aws_kendra_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("error_message");
        SetOutput("index_statistics");
        SetOutput("status");
        SetOutput("updated_at");
        SetOutput("description");
        SetOutput("edition");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_context_policy");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformProperty<string> UserContextPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_context_policy");
        set => SetProperty("user_context_policy", value);
    }

    /// <summary>
    /// Block for capacity_units.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityUnits block(s) allowed")]
    public List<AwsKendraIndexCapacityUnitsBlock>? CapacityUnits
    {
        set => SetProperty("capacity_units", value);
    }

    /// <summary>
    /// Block for document_metadata_configuration_updates.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 DocumentMetadataConfigurationUpdates block(s) allowed")]
    public HashSet<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>? DocumentMetadataConfigurationUpdates
    {
        set => SetProperty("document_metadata_configuration_updates", value);
    }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    public List<AwsKendraIndexServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        set => SetProperty("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKendraIndexTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_group_resolution_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserGroupResolutionConfiguration block(s) allowed")]
    public List<AwsKendraIndexUserGroupResolutionConfigurationBlock>? UserGroupResolutionConfiguration
    {
        set => SetProperty("user_group_resolution_configuration", value);
    }

    /// <summary>
    /// Block for user_token_configurations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserTokenConfigurations block(s) allowed")]
    public List<AwsKendraIndexUserTokenConfigurationsBlock>? UserTokenConfigurations
    {
        set => SetProperty("user_token_configurations", value);
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

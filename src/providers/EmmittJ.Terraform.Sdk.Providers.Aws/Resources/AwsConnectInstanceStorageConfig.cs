using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_type");
        set => WithProperty("storage_type", value);
    }

}

/// <summary>
/// Manages a aws_connect_instance_storage_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectInstanceStorageConfig : TerraformResource
{
    public AwsConnectInstanceStorageConfig(string name) : base("aws_connect_instance_storage_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("association_id");
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public List<AwsConnectInstanceStorageConfigStorageConfigBlock>? StorageConfig
    {
        get => GetProperty<List<AwsConnectInstanceStorageConfigStorageConfigBlock>>("storage_config");
        set => this.WithProperty("storage_config", value);
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}

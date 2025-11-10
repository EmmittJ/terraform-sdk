using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_instance_storage_config.
/// </summary>
public class AwsConnectInstanceStorageConfigDataSource : TerraformDataSource
{
    public AwsConnectInstanceStorageConfigDataSource(string name) : base("aws_connect_instance_storage_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("storage_config");
        SetOutput("association_id");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("region");
        SetOutput("resource_type");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociationId is required")]
    public required TerraformProperty<string> AssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("association_id");
        set => SetProperty("association_id", value);
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    public TerraformExpression StorageConfig => this["storage_config"];

}

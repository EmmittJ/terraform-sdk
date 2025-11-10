using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersVirtualClusterContainerProviderBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEmrcontainersVirtualClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_emrcontainers_virtual_cluster resource.
/// </summary>
public class AwsEmrcontainersVirtualCluster : TerraformResource
{
    public AwsEmrcontainersVirtualCluster(string name) : base("aws_emrcontainers_virtual_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// Block for container_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContainerProvider block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerProvider block(s) allowed")]
    public List<AwsEmrcontainersVirtualClusterContainerProviderBlock>? ContainerProvider
    {
        get => GetProperty<List<AwsEmrcontainersVirtualClusterContainerProviderBlock>>("container_provider");
        set => this.WithProperty("container_provider", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEmrcontainersVirtualClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEmrcontainersVirtualClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

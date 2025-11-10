using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nas1_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxVolumeNas1ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
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
public class AwsFinspaceKxVolumeTimeoutsBlock : TerraformBlock
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
/// Manages a aws_finspace_kx_volume resource.
/// </summary>
public class AwsFinspaceKxVolume : TerraformResource
{
    public AwsFinspaceKxVolume(string name) : base("aws_finspace_kx_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attached_clusters");
        this.DeclareOutput("created_timestamp");
        this.DeclareOutput("last_modified_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZones is required")]
    public List<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<List<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformProperty<string> AzMode
    {
        get => GetProperty<TerraformProperty<string>>("az_mode");
        set => this.WithProperty("az_mode", value);
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
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for nas1_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxVolumeNas1ConfigurationBlock>? Nas1Configuration
    {
        get => GetProperty<List<AwsFinspaceKxVolumeNas1ConfigurationBlock>>("nas1_configuration");
        set => this.WithProperty("nas1_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxVolumeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFinspaceKxVolumeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attached_clusters attribute.
    /// </summary>
    public TerraformExpression AttachedClusters => this["attached_clusters"];

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformExpression CreatedTimestamp => this["created_timestamp"];

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformExpression LastModifiedTimestamp => this["last_modified_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}

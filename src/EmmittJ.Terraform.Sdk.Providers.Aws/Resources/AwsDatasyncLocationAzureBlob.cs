using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_azure_blob resource.
/// </summary>
public class AwsDatasyncLocationAzureBlob : TerraformResource
{
    public AwsDatasyncLocationAzureBlob(string name) : base("aws_datasync_location_azure_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformProperty<string>? AccessTier
    {
        get => GetProperty<TerraformProperty<string>>("access_tier");
        set => this.WithProperty("access_tier", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AgentArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    public TerraformProperty<string>? BlobType
    {
        get => GetProperty<TerraformProperty<string>>("blob_type");
        set => this.WithProperty("blob_type", value);
    }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerUrl
    {
        get => GetProperty<TerraformProperty<string>>("container_url");
        set => this.WithProperty("container_url", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformProperty<string>? Subdirectory
    {
        get => GetProperty<TerraformProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}

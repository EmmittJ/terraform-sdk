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
    public string? AccessTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_tier")?.Value;
        set => this.WithProperty("access_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<string>? AgentArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("agent_arns")?.Value;
        set => this.WithProperty("agent_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public string? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type")?.Value;
        set => this.WithProperty("authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    public string? BlobType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_type")?.Value;
        set => this.WithProperty("blob_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    public string? ContainerUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_url")?.Value;
        set => this.WithProperty("container_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public string? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory")?.Value;
        set => this.WithProperty("subdirectory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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

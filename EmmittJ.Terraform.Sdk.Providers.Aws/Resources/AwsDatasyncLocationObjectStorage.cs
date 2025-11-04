using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_object_storage resource.
/// </summary>
public class AwsDatasyncLocationObjectStorage : TerraformResource
{
    public AwsDatasyncLocationObjectStorage(string name) : base("aws_datasync_location_object_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public string? AccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_key")?.Value;
        set => this.WithProperty("access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The bucket_name attribute.
    /// </summary>
    public string? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name")?.Value;
        set => this.WithProperty("bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    public string? SecretKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_key")?.Value;
        set => this.WithProperty("secret_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public string? ServerCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_certificate")?.Value;
        set => this.WithProperty("server_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    public string? ServerHostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_hostname")?.Value;
        set => this.WithProperty("server_hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public double? ServerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("server_port")?.Value;
        set => this.WithProperty("server_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public string? ServerProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_protocol")?.Value;
        set => this.WithProperty("server_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
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

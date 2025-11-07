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
    public TerraformLiteralProperty<string>? AccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_key");
        set => this.WithProperty("access_key", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AgentArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_key");
        set => this.WithProperty("secret_key", value);
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_certificate");
        set => this.WithProperty("server_certificate", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerHostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_hostname");
        set => this.WithProperty("server_hostname", value);
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ServerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("server_port");
        set => this.WithProperty("server_port", value);
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_protocol");
        set => this.WithProperty("server_protocol", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
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

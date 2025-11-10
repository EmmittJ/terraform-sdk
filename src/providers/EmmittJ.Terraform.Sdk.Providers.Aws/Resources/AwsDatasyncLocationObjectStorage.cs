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
        this.WithOutput("arn");
        this.WithOutput("uri");
    }

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccessKey
    {
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => this.WithProperty("access_key", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AgentArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
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
    /// The secret_key attribute.
    /// </summary>
    public TerraformProperty<string>? SecretKey
    {
        get => GetProperty<TerraformProperty<string>>("secret_key");
        set => this.WithProperty("secret_key", value);
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public TerraformProperty<string>? ServerCertificate
    {
        get => GetProperty<TerraformProperty<string>>("server_certificate");
        set => this.WithProperty("server_certificate", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformProperty<string> ServerHostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_hostname");
        set => this.WithProperty("server_hostname", value);
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformProperty<double>? ServerPort
    {
        get => GetProperty<TerraformProperty<double>>("server_port");
        set => this.WithProperty("server_port", value);
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ServerProtocol
    {
        get => GetProperty<TerraformProperty<string>>("server_protocol");
        set => this.WithProperty("server_protocol", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}

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
        SetOutput("arn");
        SetOutput("uri");
        SetOutput("access_key");
        SetOutput("agent_arns");
        SetOutput("bucket_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_key");
        SetOutput("server_certificate");
        SetOutput("server_hostname");
        SetOutput("server_port");
        SetOutput("server_protocol");
        SetOutput("subdirectory");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformProperty<string> AccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_key");
        set => SetProperty("access_key", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AgentArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("agent_arns");
        set => SetProperty("agent_arns", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_name");
        set => SetProperty("bucket_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    public TerraformProperty<string> SecretKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_key");
        set => SetProperty("secret_key", value);
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public TerraformProperty<string> ServerCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_certificate");
        set => SetProperty("server_certificate", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformProperty<string> ServerHostname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_hostname");
        set => SetProperty("server_hostname", value);
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformProperty<double> ServerPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("server_port");
        set => SetProperty("server_port", value);
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformProperty<string> ServerProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_protocol");
        set => SetProperty("server_protocol", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformProperty<string> Subdirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subdirectory");
        set => SetProperty("subdirectory", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}

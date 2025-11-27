using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_datasync_location_object_storage Terraform resource.
/// Manages a aws_datasync_location_object_storage resource.
/// </summary>
public partial class AwsDatasyncLocationObjectStorage(string name) : TerraformResource("aws_datasync_location_object_storage", name)
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public TerraformSet<string>? AgentArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "agent_arns").ResolveNodes(ctx));
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    public TerraformValue<string>? SecretKey
    {
        get => new TerraformReference<string>(this, "secret_key");
        set => SetArgument("secret_key", value);
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public TerraformValue<string>? ServerCertificate
    {
        get => new TerraformReference<string>(this, "server_certificate");
        set => SetArgument("server_certificate", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformValue<string> ServerHostname
    {
        get => new TerraformReference<string>(this, "server_hostname");
        set => SetArgument("server_hostname", value);
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformValue<double>? ServerPort
    {
        get => new TerraformReference<double>(this, "server_port");
        set => SetArgument("server_port", value);
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ServerProtocol
    {
        get => new TerraformReference<string>(this, "server_protocol");
        set => SetArgument("server_protocol", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string> Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

}

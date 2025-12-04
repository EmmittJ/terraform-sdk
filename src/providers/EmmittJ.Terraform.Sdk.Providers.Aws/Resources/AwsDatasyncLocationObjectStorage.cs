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
        get => GetArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public TerraformSet<string>? AgentArns
    {
        get => GetArgument<TerraformSet<string>>("agent_arns");
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    public TerraformValue<string>? SecretKey
    {
        get => GetArgument<TerraformValue<string>>("secret_key");
        set => SetArgument("secret_key", value);
    }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    public TerraformValue<string>? ServerCertificate
    {
        get => GetArgument<TerraformValue<string>>("server_certificate");
        set => SetArgument("server_certificate", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformValue<string> ServerHostname
    {
        get => GetArgument<TerraformValue<string>>("server_hostname");
        set => SetArgument("server_hostname", value);
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformValue<double>? ServerPort
    {
        get => GetArgument<TerraformValue<double>>("server_port");
        set => SetArgument("server_port", value);
    }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ServerProtocol
    {
        get => GetArgument<TerraformValue<string>>("server_protocol");
        set => SetArgument("server_protocol", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => GetArgument<TerraformValue<string>>("subdirectory");
        set => SetArgument("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
        => AsReference("uri");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_dev_endpoint Terraform resource.
/// Manages a aws_glue_dev_endpoint resource.
/// </summary>
public partial class AwsGlueDevEndpoint(string name) : TerraformResource("aws_glue_dev_endpoint", name)
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public TerraformMap<string>? Arguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "arguments").ResolveNodes(ctx));
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    public TerraformValue<string>? ExtraJarsS3Path
    {
        get => new TerraformReference<string>(this, "extra_jars_s3_path");
        set => SetArgument("extra_jars_s3_path", value);
    }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    public TerraformValue<string>? ExtraPythonLibsS3Path
    {
        get => new TerraformReference<string>(this, "extra_python_libs_s3_path");
        set => SetArgument("extra_python_libs_s3_path", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformValue<string>? GlueVersion
    {
        get => new TerraformReference<string>(this, "glue_version");
        set => SetArgument("glue_version", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => new TerraformReference<double>(this, "number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfWorkers
    {
        get => new TerraformReference<double>(this, "number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string>? PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    public TerraformSet<string>? PublicKeys
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "public_keys").ResolveNodes(ctx));
        set => SetArgument("public_keys", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformValue<string>? SecurityConfiguration
    {
        get => new TerraformReference<string>(this, "security_configuration");
        set => SetArgument("security_configuration", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The worker_type attribute.
    /// </summary>
    public TerraformValue<string>? WorkerType
    {
        get => new TerraformReference<string>(this, "worker_type");
        set => SetArgument("worker_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
    {
        get => new TerraformReference<string>(this, "failure_reason");
    }

    /// <summary>
    /// The private_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateAddress
    {
        get => new TerraformReference<string>(this, "private_address");
    }

    /// <summary>
    /// The public_address attribute.
    /// </summary>
    public TerraformValue<string> PublicAddress
    {
        get => new TerraformReference<string>(this, "public_address");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The yarn_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> YarnEndpointAddress
    {
        get => new TerraformReference<string>(this, "yarn_endpoint_address");
    }

    /// <summary>
    /// The zeppelin_remote_spark_interpreter_port attribute.
    /// </summary>
    public TerraformValue<double> ZeppelinRemoteSparkInterpreterPort
    {
        get => new TerraformReference<double>(this, "zeppelin_remote_spark_interpreter_port");
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_finspace_kx_cluster resource.
/// </summary>
public class AwsFinspaceKxCluster : TerraformResource
{
    public AwsFinspaceKxCluster(string name) : base("aws_finspace_kx_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_timestamp");
        this.DeclareOutput("last_modified_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AzMode
    {
        get => GetProperty<TerraformProperty<string>>("az_mode");
        set => this.WithProperty("az_mode", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformMapProperty<string>? CommandLineArguments
    {
        get => GetProperty<TerraformMapProperty<string>>("command_line_arguments");
        set => this.WithProperty("command_line_arguments", value);
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
    public TerraformProperty<string>? EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => this.WithProperty("execution_role", value);
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
    /// The initialization_script attribute.
    /// </summary>
    public TerraformProperty<string>? InitializationScript
    {
        get => GetProperty<TerraformProperty<string>>("initialization_script");
        set => this.WithProperty("initialization_script", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    /// The release_label attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseLabel
    {
        get => GetProperty<TerraformProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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

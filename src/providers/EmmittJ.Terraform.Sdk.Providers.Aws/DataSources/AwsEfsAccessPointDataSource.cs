using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_access_point.
/// </summary>
public class AwsEfsAccessPointDataSource : TerraformDataSource
{
    public AwsEfsAccessPointDataSource(string name) : base("aws_efs_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("file_system_arn");
        this.WithOutput("file_system_id");
        this.WithOutput("owner_id");
        this.WithOutput("posix_user");
        this.WithOutput("root_directory");
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointId is required")]
    public required TerraformProperty<string> AccessPointId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access_point_id");
        set => this.WithProperty("access_point_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformExpression FileSystemArn => this["file_system_arn"];

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformExpression FileSystemId => this["file_system_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The posix_user attribute.
    /// </summary>
    public TerraformExpression PosixUser => this["posix_user"];

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    public TerraformExpression RootDirectory => this["root_directory"];

}

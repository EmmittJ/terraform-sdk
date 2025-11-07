using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_efs resource.
/// </summary>
public class AwsDatasyncLocationEfs : TerraformResource
{
    public AwsDatasyncLocationEfs(string name) : base("aws_datasync_location_efs", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessPointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_point_arn");
        set => this.WithProperty("access_point_arn", value);
    }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EfsFileSystemArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("efs_file_system_arn");
        set => this.WithProperty("efs_file_system_arn", value);
    }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileSystemAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_access_role_arn");
        set => this.WithProperty("file_system_access_role_arn", value);
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
    /// The in_transit_encryption attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InTransitEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("in_transit_encryption");
        set => this.WithProperty("in_transit_encryption", value);
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

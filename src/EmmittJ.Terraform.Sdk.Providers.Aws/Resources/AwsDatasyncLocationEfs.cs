using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ec2_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationEfsEc2ConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_arns");
        set => WithProperty("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArn is required")]
    public required TerraformProperty<string> SubnetArn
    {
        get => GetProperty<TerraformProperty<string>>("subnet_arn");
        set => WithProperty("subnet_arn", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_efs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? AccessPointArn
    {
        get => GetProperty<TerraformProperty<string>>("access_point_arn");
        set => this.WithProperty("access_point_arn", value);
    }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystemArn is required")]
    public required TerraformProperty<string> EfsFileSystemArn
    {
        get => GetProperty<TerraformProperty<string>>("efs_file_system_arn");
        set => this.WithProperty("efs_file_system_arn", value);
    }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("file_system_access_role_arn");
        set => this.WithProperty("file_system_access_role_arn", value);
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
    /// The in_transit_encryption attribute.
    /// </summary>
    public TerraformProperty<string>? InTransitEncryption
    {
        get => GetProperty<TerraformProperty<string>>("in_transit_encryption");
        set => this.WithProperty("in_transit_encryption", value);
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
    /// Block for ec2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ec2Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Config block(s) allowed")]
    public List<AwsDatasyncLocationEfsEc2ConfigBlock>? Ec2Config
    {
        get => GetProperty<List<AwsDatasyncLocationEfsEc2ConfigBlock>>("ec2_config");
        set => this.WithProperty("ec2_config", value);
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

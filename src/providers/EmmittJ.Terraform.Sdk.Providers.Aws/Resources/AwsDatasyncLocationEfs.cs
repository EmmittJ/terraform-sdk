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
        set => SetProperty("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArn is required")]
    public required TerraformProperty<string> SubnetArn
    {
        set => SetProperty("subnet_arn", value);
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
        SetOutput("arn");
        SetOutput("uri");
        SetOutput("access_point_arn");
        SetOutput("efs_file_system_arn");
        SetOutput("file_system_access_role_arn");
        SetOutput("id");
        SetOutput("in_transit_encryption");
        SetOutput("region");
        SetOutput("subdirectory");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    public TerraformProperty<string> AccessPointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_point_arn");
        set => SetProperty("access_point_arn", value);
    }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystemArn is required")]
    public required TerraformProperty<string> EfsFileSystemArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("efs_file_system_arn");
        set => SetProperty("efs_file_system_arn", value);
    }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> FileSystemAccessRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_access_role_arn");
        set => SetProperty("file_system_access_role_arn", value);
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
    /// The in_transit_encryption attribute.
    /// </summary>
    public TerraformProperty<string> InTransitEncryption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("in_transit_encryption");
        set => SetProperty("in_transit_encryption", value);
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
    /// Block for ec2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ec2Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Config block(s) allowed")]
    public List<AwsDatasyncLocationEfsEc2ConfigBlock>? Ec2Config
    {
        set => SetProperty("ec2_config", value);
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

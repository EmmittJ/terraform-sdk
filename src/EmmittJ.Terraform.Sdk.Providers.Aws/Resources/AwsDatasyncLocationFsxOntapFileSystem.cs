using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protocol in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_datasync_location_fsx_ontap_file_system resource.
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystem : TerraformResource
{
    public AwsDatasyncLocationFsxOntapFileSystem(string name) : base("aws_datasync_location_fsx_ontap_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("fsx_filesystem_arn");
        this.DeclareOutput("uri");
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
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_arns");
        set => this.WithProperty("security_group_arns", value);
    }

    /// <summary>
    /// The storage_virtual_machine_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineArn is required")]
    public required TerraformProperty<string> StorageVirtualMachineArn
    {
        get => GetProperty<TerraformProperty<string>>("storage_virtual_machine_arn");
        set => this.WithProperty("storage_virtual_machine_arn", value);
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
    /// Block for protocol.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Protocol block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocol block(s) allowed")]
    public List<AwsDatasyncLocationFsxOntapFileSystemProtocolBlock>? Protocol
    {
        get => GetProperty<List<AwsDatasyncLocationFsxOntapFileSystemProtocolBlock>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The fsx_filesystem_arn attribute.
    /// </summary>
    public TerraformExpression FsxFilesystemArn => this["fsx_filesystem_arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}

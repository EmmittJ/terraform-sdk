using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_arns")?.Value;
        set => this.WithProperty("security_group_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The storage_virtual_machine_arn attribute.
    /// </summary>
    public string? StorageVirtualMachineArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_virtual_machine_arn")?.Value;
        set => this.WithProperty("storage_virtual_machine_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public string? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory")?.Value;
        set => this.WithProperty("subdirectory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The netbios_name attribute.
    /// </summary>
    public TerraformProperty<string>? NetbiosName
    {
        set => SetProperty("netbios_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapStorageVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_fsx_ontap_storage_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOntapStorageVirtualMachine : TerraformResource
{
    public AwsFsxOntapStorageVirtualMachine(string name) : base("aws_fsx_ontap_storage_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoints");
        SetOutput("subtype");
        SetOutput("uuid");
        SetOutput("file_system_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("root_volume_security_style");
        SetOutput("svm_admin_password");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformProperty<string> FileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_id");
        set => SetProperty("file_system_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The root_volume_security_style attribute.
    /// </summary>
    public TerraformProperty<string> RootVolumeSecurityStyle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("root_volume_security_style");
        set => SetProperty("root_volume_security_style", value);
    }

    /// <summary>
    /// The svm_admin_password attribute.
    /// </summary>
    public TerraformProperty<string> SvmAdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("svm_admin_password");
        set => SetProperty("svm_admin_password", value);
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
    /// Block for active_directory_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfiguration block(s) allowed")]
    public List<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock>? ActiveDirectoryConfiguration
    {
        set => SetProperty("active_directory_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOntapStorageVirtualMachineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformExpression Subtype => this["subtype"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}

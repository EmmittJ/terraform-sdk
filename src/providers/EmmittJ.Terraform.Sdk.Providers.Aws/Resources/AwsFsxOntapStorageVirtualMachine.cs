using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_configuration in AwsFsxOntapStorageVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory_configuration";

    /// <summary>
    /// The netbios_name attribute.
    /// </summary>
    public TerraformValue<string>? NetbiosName
    {
        get => GetArgument<TerraformValue<string>>("netbios_name");
        set => SetArgument("netbios_name", value);
    }

    /// <summary>
    /// SelfManagedActiveDirectoryConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectoryConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlockSelfManagedActiveDirectoryConfigurationBlock>? SelfManagedActiveDirectoryConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlockSelfManagedActiveDirectoryConfigurationBlock>>("self_managed_active_directory_configuration");
        set => SetArgument("self_managed_active_directory_configuration", value);
    }

}

/// <summary>
/// Block type for self_managed_active_directory_configuration in AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlockSelfManagedActiveDirectoryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed_active_directory_configuration";

    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsIps is required")]
    public required TerraformSet<string> DnsIps
    {
        get => GetRequiredArgument<TerraformSet<string>>("dns_ips");
        set => SetArgument("dns_ips", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemAdministratorsGroup
    {
        get => GetArgument<TerraformValue<string>>("file_system_administrators_group");
        set => SetArgument("file_system_administrators_group", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitDistinguishedName
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit_distinguished_name");
        set => SetArgument("organizational_unit_distinguished_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxOntapStorageVirtualMachine.
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapStorageVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_ontap_storage_virtual_machine Terraform resource.
/// Manages a aws_fsx_ontap_storage_virtual_machine resource.
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachine(string name) : TerraformResource("aws_fsx_ontap_storage_virtual_machine", name)
{
    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The root_volume_security_style attribute.
    /// </summary>
    public TerraformValue<string>? RootVolumeSecurityStyle
    {
        get => GetArgument<TerraformValue<string>>("root_volume_security_style");
        set => SetArgument("root_volume_security_style", value);
    }

    /// <summary>
    /// The svm_admin_password attribute.
    /// </summary>
    public TerraformValue<string>? SvmAdminPassword
    {
        get => GetArgument<TerraformValue<string>>("svm_admin_password");
        set => SetArgument("svm_admin_password", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
        => AsReference("endpoints");

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformValue<string> Subtype
        => AsReference("subtype");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformValue<string> Uuid
        => AsReference("uuid");

    /// <summary>
    /// ActiveDirectoryConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock>? ActiveDirectoryConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock>>("active_directory_configuration");
        set => SetArgument("active_directory_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxOntapStorageVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxOntapStorageVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

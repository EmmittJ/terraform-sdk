using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in AwsGuarddutyOrganizationConfiguration.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datasources";

    /// <summary>
    /// Kubernetes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kubernetes block(s) allowed")]
    public TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlock>? Kubernetes
    {
        get => GetArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlock>>("kubernetes");
        set => SetArgument("kubernetes", value);
    }

    /// <summary>
    /// MalwareProtection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MalwareProtection block(s) allowed")]
    public TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlock>? MalwareProtection
    {
        get => GetArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlock>>("malware_protection");
        set => SetArgument("malware_protection", value);
    }

    /// <summary>
    /// S3Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Logs block(s) allowed")]
    public TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockS3LogsBlock>? S3Logs
    {
        get => GetArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockS3LogsBlock>>("s3_logs");
        set => SetArgument("s3_logs", value);
    }

}

/// <summary>
/// Block type for kubernetes in AwsGuarddutyOrganizationConfigurationDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes";

    /// <summary>
    /// AuditLogs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuditLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuditLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogs block(s) allowed")]
    public required TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlockAuditLogsBlock> AuditLogs
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlockAuditLogsBlock>>("audit_logs");
        set => SetArgument("audit_logs", value);
    }

}

/// <summary>
/// Block type for audit_logs in AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockKubernetesBlockAuditLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_logs";

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformValue<bool> Enable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

}

/// <summary>
/// Block type for malware_protection in AwsGuarddutyOrganizationConfigurationDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malware_protection";

    /// <summary>
    /// ScanEc2InstanceWithFindings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanEc2InstanceWithFindings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScanEc2InstanceWithFindings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScanEc2InstanceWithFindings block(s) allowed")]
    public required TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock> ScanEc2InstanceWithFindings
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock>>("scan_ec2_instance_with_findings");
        set => SetArgument("scan_ec2_instance_with_findings", value);
    }

}

/// <summary>
/// Block type for scan_ec2_instance_with_findings in AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scan_ec2_instance_with_findings";

    /// <summary>
    /// EbsVolumes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsVolumes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EbsVolumes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsVolumes block(s) allowed")]
    public required TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock> EbsVolumes
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock>>("ebs_volumes");
        set => SetArgument("ebs_volumes", value);
    }

}

/// <summary>
/// Block type for ebs_volumes in AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_volumes";

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<bool> AutoEnable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("auto_enable");
        set => SetArgument("auto_enable", value);
    }

}

/// <summary>
/// Block type for s3_logs in AwsGuarddutyOrganizationConfigurationDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlockS3LogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_logs";

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<bool> AutoEnable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("auto_enable");
        set => SetArgument("auto_enable", value);
    }

}


/// <summary>
/// Represents a aws_guardduty_organization_configuration Terraform resource.
/// Manages a aws_guardduty_organization_configuration resource.
/// </summary>
public partial class AwsGuarddutyOrganizationConfiguration(string name) : TerraformResource("aws_guardduty_organization_configuration", name)
{
    /// <summary>
    /// The auto_enable_organization_members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnableOrganizationMembers is required")]
    public required TerraformValue<string> AutoEnableOrganizationMembers
    {
        get => GetRequiredArgument<TerraformValue<string>>("auto_enable_organization_members");
        set => SetArgument("auto_enable_organization_members", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("detector_id");
        set => SetArgument("detector_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Datasources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlock>? Datasources
    {
        get => GetArgument<TerraformList<AwsGuarddutyOrganizationConfigurationDatasourcesBlock>>("datasources");
        set => SetArgument("datasources", value);
    }

}

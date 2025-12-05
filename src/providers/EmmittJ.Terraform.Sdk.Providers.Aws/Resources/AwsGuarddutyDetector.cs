using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in AwsGuarddutyDetector.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsGuarddutyDetectorDatasourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datasources";

    /// <summary>
    /// Kubernetes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kubernetes block(s) allowed")]
    public TerraformList<AwsGuarddutyDetectorDatasourcesBlockKubernetesBlock>? Kubernetes
    {
        get => GetArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockKubernetesBlock>>("kubernetes");
        set => SetArgument("kubernetes", value);
    }

    /// <summary>
    /// MalwareProtection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MalwareProtection block(s) allowed")]
    public TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlock>? MalwareProtection
    {
        get => GetArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlock>>("malware_protection");
        set => SetArgument("malware_protection", value);
    }

    /// <summary>
    /// S3Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Logs block(s) allowed")]
    public TerraformList<AwsGuarddutyDetectorDatasourcesBlockS3LogsBlock>? S3Logs
    {
        get => GetArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockS3LogsBlock>>("s3_logs");
        set => SetArgument("s3_logs", value);
    }

}

/// <summary>
/// Block type for kubernetes in AwsGuarddutyDetectorDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockKubernetesBlock : TerraformBlock
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
    public required TerraformList<AwsGuarddutyDetectorDatasourcesBlockKubernetesBlockAuditLogsBlock> AuditLogs
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockKubernetesBlockAuditLogsBlock>>("audit_logs");
        set => SetArgument("audit_logs", value);
    }

}

/// <summary>
/// Block type for audit_logs in AwsGuarddutyDetectorDatasourcesBlockKubernetesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockKubernetesBlockAuditLogsBlock : TerraformBlock
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
/// Block type for malware_protection in AwsGuarddutyDetectorDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlock : TerraformBlock
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
    public required TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock> ScanEc2InstanceWithFindings
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock>>("scan_ec2_instance_with_findings");
        set => SetArgument("scan_ec2_instance_with_findings", value);
    }

}

/// <summary>
/// Block type for scan_ec2_instance_with_findings in AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock : TerraformBlock
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
    public required TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock> EbsVolumes
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock>>("ebs_volumes");
        set => SetArgument("ebs_volumes", value);
    }

}

/// <summary>
/// Block type for ebs_volumes in AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockMalwareProtectionBlockScanEc2InstanceWithFindingsBlockEbsVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_volumes";

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
/// Block type for s3_logs in AwsGuarddutyDetectorDatasourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlockS3LogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_logs";

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
/// Represents a aws_guardduty_detector Terraform resource.
/// Manages a aws_guardduty_detector resource.
/// </summary>
public partial class AwsGuarddutyDetector(string name) : TerraformResource("aws_guardduty_detector", name)
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformValue<string> FindingPublishingFrequency
    {
        get => GetArgument<TerraformValue<string>>("finding_publishing_frequency") ?? CreateReference("finding_publishing_frequency");
        set => SetArgument("finding_publishing_frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
        => CreateReference("account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// Datasources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsGuarddutyDetectorDatasourcesBlock>? Datasources
    {
        get => GetArgument<TerraformList<AwsGuarddutyDetectorDatasourcesBlock>>("datasources");
        set => SetArgument("datasources", value);
    }

}

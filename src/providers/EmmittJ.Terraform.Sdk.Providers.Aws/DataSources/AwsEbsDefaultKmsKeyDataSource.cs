using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEbsDefaultKmsKeyDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEbsDefaultKmsKeyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ebs_default_kms_key Terraform data source.
/// Retrieves information about a aws_ebs_default_kms_key.
/// </summary>
public partial class AwsEbsDefaultKmsKeyDataSource(string name) : TerraformDataSource("aws_ebs_default_kms_key", name)
{
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
    /// The key_arn attribute.
    /// </summary>
    public TerraformValue<string> KeyArn
        => AsReference("key_arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEbsDefaultKmsKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEbsDefaultKmsKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

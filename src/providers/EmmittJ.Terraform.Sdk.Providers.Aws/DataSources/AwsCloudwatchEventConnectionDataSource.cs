using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_event_connection Terraform data source.
/// Retrieves information about a aws_cloudwatch_event_connection.
/// </summary>
public partial class AwsCloudwatchEventConnectionDataSource(string name) : TerraformDataSource("aws_cloudwatch_event_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationType
        => CreateReference("authorization_type");

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyIdentifier
        => CreateReference("kms_key_identifier");

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretArn
        => CreateReference("secret_arn");

}

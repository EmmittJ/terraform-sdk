using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sfn_state_machine_versions Terraform data source.
/// Retrieves information about a aws_sfn_state_machine_versions.
/// </summary>
public partial class AwsSfnStateMachineVersionsDataSource(string name) : TerraformDataSource("aws_sfn_state_machine_versions", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The statemachine_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatemachineArn is required")]
    public required TerraformValue<string> StatemachineArn
    {
        get => new TerraformReference<string>(this, "statemachine_arn");
        set => SetArgument("statemachine_arn", value);
    }

    /// <summary>
    /// The statemachine_versions attribute.
    /// </summary>
    public TerraformList<string> StatemachineVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "statemachine_versions").ResolveNodes(ctx));
    }

}

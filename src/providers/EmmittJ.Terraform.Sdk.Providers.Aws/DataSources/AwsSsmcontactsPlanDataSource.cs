using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssmcontacts_plan Terraform data source.
/// Retrieves information about a aws_ssmcontacts_plan.
/// </summary>
public partial class AwsSsmcontactsPlanDataSource(string name) : TerraformDataSource("aws_ssmcontacts_plan", name)
{
    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    public required TerraformValue<string> ContactId
    {
        get => GetRequiredArgument<TerraformValue<string>>("contact_id");
        set => SetArgument("contact_id", value);
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
    /// The stage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Stage
        => CreateReference("stage");

}

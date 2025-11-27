using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_verifiedpermissions_policy_template Terraform resource.
/// Manages a aws_verifiedpermissions_policy_template resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicyTemplate(string name) : TerraformResource("aws_verifiedpermissions_policy_template", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformValue<string> PolicyStoreId
    {
        get => new TerraformReference<string>(this, "policy_store_id");
        set => SetArgument("policy_store_id", value);
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
    /// The statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statement is required")]
    public required TerraformValue<string> Statement
    {
        get => new TerraformReference<string>(this, "statement");
        set => SetArgument("statement", value);
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The policy_template_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyTemplateId
    {
        get => new TerraformReference<string>(this, "policy_template_id");
    }

}

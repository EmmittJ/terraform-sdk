using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_group_membership resource.
/// </summary>
public class AwsIotThingGroupMembership : TerraformResource
{
    public AwsIotThingGroupMembership(string name) : base("aws_iot_thing_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("override_dynamic_group");
        SetOutput("region");
        SetOutput("thing_group_name");
        SetOutput("thing_name");
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
    /// The override_dynamic_group attribute.
    /// </summary>
    public TerraformProperty<bool> OverrideDynamicGroup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("override_dynamic_group");
        set => SetProperty("override_dynamic_group", value);
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
    /// The thing_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupName is required")]
    public required TerraformProperty<string> ThingGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thing_group_name");
        set => SetProperty("thing_group_name", value);
    }

    /// <summary>
    /// The thing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingName is required")]
    public required TerraformProperty<string> ThingName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thing_name");
        set => SetProperty("thing_name", value);
    }

}

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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The override_dynamic_group attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OverrideDynamicGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override_dynamic_group");
        set => this.WithProperty("override_dynamic_group", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The thing_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ThingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_group_name");
        set => this.WithProperty("thing_group_name", value);
    }

    /// <summary>
    /// The thing_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ThingName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_name");
        set => this.WithProperty("thing_name", value);
    }

}

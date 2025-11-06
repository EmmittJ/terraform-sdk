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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The override_dynamic_group attribute.
    /// </summary>
    public bool? OverrideDynamicGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override_dynamic_group")?.Value;
        set => this.WithProperty("override_dynamic_group", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thing_group_name attribute.
    /// </summary>
    public string? ThingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_group_name")?.Value;
        set => this.WithProperty("thing_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thing_name attribute.
    /// </summary>
    public string? ThingName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_name")?.Value;
        set => this.WithProperty("thing_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

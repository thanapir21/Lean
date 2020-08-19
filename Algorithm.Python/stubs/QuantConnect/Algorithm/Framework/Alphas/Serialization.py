# encoding: utf-8
# module QuantConnect.Algorithm.Framework.Alphas.Serialization calls itself Serialization
# from QuantConnect.Common, Version=2.4.0.0, Culture=neutral, PublicKeyToken=null
# by generator 1.145
# no doc

# imports
import datetime
import QuantConnect.Algorithm.Framework.Alphas
import typing

# no functions
# classes

class InsightJsonConverter(QuantConnect.Util.TypeChangeJsonConverter[Insight, SerializedInsight]):
    """
    Defines how insights should be serialized to json
    
    InsightJsonConverter()
    """


class SerializedInsight(System.object):
    """
    DTO used for serializing an insight that was just generated by an algorithm.
                This type does not contain any of the analysis dependent fields, such as scores
                and estimated value
    
    SerializedInsight()
    SerializedInsight(insight: Insight)
    """
    @staticmethod # known case of __new__
    @typing.overload
    def __new__(self) -> None:
        pass

    @typing.overload
    def __new__(self, insight: QuantConnect.Algorithm.Framework.Alphas.Insight) -> None:
        pass

    def __new__(self, *args) -> None:
        pass

    CloseTime: float

    Confidence: typing.Optional[float]

    CreatedTime: float

    Direction: QuantConnect.Algorithm.Framework.Alphas.InsightDirection

    EstimatedValue: float

    GeneratedTime: float

    GroupId: str

    Id: str

    Magnitude: typing.Optional[float]

    Period: float

    ReferenceValue: float

    ReferenceValueFinal: float

    ScoreDirection: float

    ScoreIsFinal: bool

    ScoreMagnitude: float

    SourceModel: str

    Symbol: str

    Ticker: str

    Type: QuantConnect.Algorithm.Framework.Alphas.InsightType

    Weight: typing.Optional[float]




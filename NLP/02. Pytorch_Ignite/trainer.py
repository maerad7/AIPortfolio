from copy import deepcopy

import numpy as numpy
import torch
import torch.nn.functional as F
import torch.optim as optim
import torch.nn.utils as torch_utils

from ignite.enjine import Enjine
from ignite.enjine import Events
from ignite.metrics import RunningAverage
